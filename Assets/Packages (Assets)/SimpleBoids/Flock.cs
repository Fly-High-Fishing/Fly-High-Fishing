using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.Jobs;
using Utility;
using Random = UnityEngine.Random;

namespace Boids
{
    public class Flock : MonoBehaviour
    {
        [SerializeField] private GameObject _AgentPrefab;
        [Header("Coefficients")]
        [Tooltip("Tendency to follow own existing alignment.")]
        [SerializeField] private float _IndependentAlignmentCoefficient = 1.0f;
        [Tooltip("Tendency to follow the alignment of nearby boids.")]
        [SerializeField] private float _AlignmentCoefficient = 1.0f;
        [Tooltip("Tendency to move away from nearby boids.")]
        [SerializeField] private float _SeparationCoefficient = 1.0f;
        [Tooltip("Tendency to move towards group centres.")]
        [SerializeField] private float _CohesionCoefficient = 1.0f;

        [Header("Other Settings")]
        [Tooltip("Minimum distance from Flock object a boid may wander.")]
        [SerializeField] private float _MinWanderDistance = 1.0f;
        [Tooltip("Maximum distance from Flock object a boid may wander.")]
        [SerializeField] private float _MaxWanderDistance = 20.0f;
        [Tooltip("Distance within which another boid is considered a neighbour.")]
        [SerializeField] private float _ViewRadius = 5.0f;
        [Tooltip("Units per second movement speed.")]
        [SerializeField] private float _Speed = 5.0f;
        [Tooltip("Degrees per second rotation speed.")]
        [SerializeField] private float _RotationSpeed = 90.0f;
        [Tooltip("Distance of the collision avoidance rays.")]
        [SerializeField] private float _CollisionDistance = 2.0f;

        [SerializeField] private int _InitialSpawnCount = 32;

        [Header("Debug")] [SerializeField] private Color _GizmoColour = Color.red;

        private struct BoidTransformJob : IJobParallelForTransform
        {
            public float DeltaSpeed;
            public float RotationDelta;
            public NativeArray<Vector3> Headings;

            public void Execute(int index, TransformAccess transform)
            {
                transform.localRotation = Quaternion.RotateTowards(transform.localRotation, Quaternion.LookRotation(Headings[index], Vector3.up), RotationDelta);
                transform.localPosition += transform.localRotation * Vector3.forward * DeltaSpeed;
            }
        }

        private const int _RayCount = 64;
        private static Vector3[] _RayDirections;

        private HashSet<GameObject> _Agents;
        private List<Transform> _AgentTransforms;
        private TransformAccessArray _AgentTransformAccess;
        private NativeList<Vector3> _Headings;

        public void AddAgent(GameObject agent)
        {
            _Agents.Add(agent);
            agent.GetComponent<FlockMember>().Flock = this;
            _AgentTransforms.Add(agent.transform);
            _AgentTransformAccess.SetTransforms(_AgentTransforms.ToArray());
            _Headings.Add(agent.transform.forward);
        }
        
        public void CreateAgent(Vector3 position)
        {
            var agent = Instantiate(_AgentPrefab, position, Quaternion.identity);
            agent.AddComponent<FlockMember>().Flock = this;
            _Agents.Add(agent);
            _AgentTransforms.Add(agent.transform);
            _AgentTransformAccess.SetTransforms(_AgentTransforms.ToArray());
            _Headings.Add(agent.transform.forward);
        }

        public void RemoveAgent(GameObject agent)
        {
            var index = _AgentTransforms.FindIndex(0, t => t == agent.transform);
            agent.GetComponent<FlockMember>().Flock = null;
            _Agents.Remove(agent);
            _AgentTransforms.RemoveAt(index);
            _AgentTransformAccess.SetTransforms(_AgentTransforms.ToArray());
            _Headings.RemoveAt(index);
        }

        // Start is called before the first frame update
        private void Awake()
        {
            _AgentTransforms = new List<Transform>(_InitialSpawnCount);
            _AgentTransformAccess = new TransformAccessArray(_InitialSpawnCount);
            _Headings = new NativeList<Vector3>(_InitialSpawnCount);
            _Agents = new HashSet<GameObject>();

            for (var i = 0; i < _InitialSpawnCount; i++)
            {
                var randomPos = Random.insideUnitSphere;
                CreateAgent(transform.position + (randomPos.normalized * _MinWanderDistance) + randomPos * _MaxWanderDistance);
            }

            _RayDirections ??= Utility.PointsOnSphere.GeneratePoints(_RayCount);
        }

        private void CalculateBoid(int index)
        {
            var agentTransform = _AgentTransforms[index];
            var heading = _Headings[index];
            var neighbours = Physics.OverlapSphere(agentTransform.position, _ViewRadius);
            
            var viewRadiusSqr = Mathf.Pow(_ViewRadius, 2);
            
            var neighbourCount = 1;
            var alignment = Vector3.zero;
            var cohesionCentre = agentTransform.position;
            var separation = Vector3.zero;

            foreach (var col in neighbours)
            {
                // Skip self and non-flock objects.
                if (!_Agents.Contains(col.gameObject) || agentTransform == col.transform) continue;
                var other = col.transform;

                var otherToSelf = agentTransform.position - other.position;
                var sqrDistance = otherToSelf.sqrMagnitude;
                
                if (!(sqrDistance <= viewRadiusSqr)) continue;
                
                var inverseDistanceFactor = 1 - (sqrDistance / viewRadiusSqr);
                alignment += other.forward * inverseDistanceFactor;
                separation += otherToSelf.normalized * inverseDistanceFactor;
                cohesionCentre += other.transform.position;
                neighbourCount++;
            }

            cohesionCentre /= neighbourCount;
            var cohesion = (cohesionCentre - agentTransform.position).normalized * _CohesionCoefficient;
            alignment = (alignment / neighbourCount) * _AlignmentCoefficient;
            // alignment = Vector3.Normalize(alignment / neighbourCount) * _AlignmentCoefficient;
            separation = (separation / neighbourCount) * _SeparationCoefficient;
            // separation = Vector3.Normalize(separation / neighbourCount) * _SeparationCoefficient;
            var independentAlignment = agentTransform.forward * _IndependentAlignmentCoefficient;

            var toOrigin = transform.position - agentTransform.position;
            var originDistanceSqr = toOrigin.sqrMagnitude;

            var minWanderDistanceSqr = Mathf.Pow(_MinWanderDistance, 2);
            var maxWanderDistanceSqr = Mathf.Pow(_MaxWanderDistance, 2);

            var nearTurnStartDistanceSqr = minWanderDistanceSqr * 1.2f;
            var farTurnStartDistanceSqr = maxWanderDistanceSqr * 0.9f;
            
            var nearTurnFactor = Mathf.Clamp01((nearTurnStartDistanceSqr - originDistanceSqr) /
                                               (nearTurnStartDistanceSqr - minWanderDistanceSqr));
            var farTurnFactor = Mathf.Clamp01((originDistanceSqr - farTurnStartDistanceSqr) /
                                           (maxWanderDistanceSqr - farTurnStartDistanceSqr));

            if (farTurnFactor > 0)
            {
                _Headings[index] = Vector3.Slerp(Vector3.Normalize(independentAlignment + cohesion + alignment + separation), toOrigin.normalized, farTurnFactor);
            }
            else
            {
                _Headings[index] = Vector3.Slerp(Vector3.Normalize(independentAlignment + cohesion + alignment + separation), -toOrigin.normalized, nearTurnFactor);
            }

            if (_CollisionDistance <= 0) return;
            
            foreach (var t in _RayDirections)
            {
                var ray = new Ray(agentTransform.position, Quaternion.LookRotation(_Headings[index], agentTransform.up) * t);
                if (Physics.RaycastAll(ray, _CollisionDistance).Any(h => h.transform != agentTransform)) continue;
                
                _Headings[index] = ray.direction;
                // Debug.DrawRay(ray.origin, ray.direction, Color.green);
                break;
            }
            
            // Debug.DrawRay(agentTransform.position, alignment * _AlignmentCoefficient, Color.red);
            // Debug.DrawRay(agentTransform.position, cohesion * _CohesionCoefficient, Color.green);
            // Debug.DrawRay(agentTransform.position, separation * _SeparationCoefficient, Color.blue);
        }
        
        // Update is called once per frame
        private void FixedUpdate()
        {
            // Parallel.For(0, _AgentTransforms.Count, CalculateBoid);
            for (var i = 0; i < _AgentTransforms.Count; i++)
            {
                CalculateBoid(i);
            }
            var job = new BoidTransformJob
            {
                Headings = _Headings.UnderlyingArray,
                DeltaSpeed = _Speed * Time.deltaTime,
                RotationDelta = _RotationSpeed * Time.deltaTime
            };
            job.Schedule(_AgentTransformAccess).Complete();
        }

        private void OnDrawGizmosSelected()
        {
            Gizmos.color = _GizmoColour;
            Gizmos.DrawWireSphere(transform.position, _MinWanderDistance);
            Gizmos.DrawWireSphere(transform.position, _MaxWanderDistance);
        }

        private void OnApplicationQuit()
        {
            _Headings.Dispose();
        }
    }

}
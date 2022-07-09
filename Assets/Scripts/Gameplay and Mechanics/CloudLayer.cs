using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Utility;
using Random = UnityEngine.Random;

public class CloudLayer : MonoBehaviour
{
    [SerializeField] private GameObject _CloudPrefab;

    [SerializeField] private float _MinSpawnRange = 5.0f;
    [SerializeField] private float _MaxSpawnRange = 20.0f;

    [SerializeField] private int _InitialSpawnCount = 8;

    [SerializeField] private float _MinScale = 0.66f;
    [SerializeField] private float _MaxScale = 1.5f;

    [SerializeField] private float _MinSpeed = 1.0f;
    [SerializeField] private float _MaxSpeed = 5.0f;

    [Tooltip("As the scale goes up, does the speed go down? (small and fast, big and slow).")]
    [SerializeField] private bool _IsSpeedInverselyCorrelatedToScale = false;

    [SerializeField] private bool _ShouldCloudsLookAtOrigin = false;

    private class CloudData
    {
        public GameObject Cloud;
        public float Speed;
    }

    private List<CloudData> _Clouds;
    
    private void CreateClouds()
    {
        _Clouds = new List<CloudData>(_InitialSpawnCount);
        var spawnDepth = _MaxSpawnRange - _MinSpawnRange;
        for (var i = 0; i < _InitialSpawnCount; i++)
        {
            var randomPos = Random.insideUnitSphere * spawnDepth;
            var spawnPos = (randomPos.normalized * _MinSpawnRange) + randomPos;
            var rotation = _ShouldCloudsLookAtOrigin
                ? Quaternion.LookRotation(transform.position - spawnPos, Vector3.up)
                : Quaternion.LookRotation(spawnPos.oyo() - spawnPos, Vector3.up);
            rotation *= Quaternion.AngleAxis(90, rotation * Vector3.up);
            var cloud = Instantiate(_CloudPrefab, spawnPos, rotation);

            var scaleRandom = Random.value;
            var scale = Mathf.Lerp(_MinScale, _MaxScale, scaleRandom);
            var speed = _IsSpeedInverselyCorrelatedToScale
                ? Mathf.Lerp(_MaxSpeed, _MinSpeed, scaleRandom)
                : Mathf.Lerp(_MinSpeed, _MaxSpeed, Random.value);

            cloud.transform.localScale = new Vector3(scale, scale, scale);
            _Clouds.Add(new CloudData(){Cloud = cloud, Speed = speed});
        }
    }
    
    // Start is called before the first frame update
    private void Start()
    {
        CreateClouds();
    }

    // Update is called once per frame
    private void Update()
    {
        foreach (var cloud in _Clouds)
        {
            cloud.Cloud.transform.RotateAround(transform.position, Vector3.up, cloud.Speed * Time.deltaTime);
            var rotation = _ShouldCloudsLookAtOrigin
                ? Quaternion.LookRotation(transform.position, Vector3.up)
                : Quaternion.LookRotation(cloud.Cloud.transform.position.oyo(), Vector3.up);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using Utility;

/// <summary>
/// Snaps connected GameObject to orthogonal directions on the XZ plane based on XR look direction.
/// </summary>
public class WorldUISnapper : MonoBehaviour
{
    private Transform _HeadCameraTransform;

    private static readonly Vector2[] _TestAxes = new Vector2[]
    {
        new Vector2(1,0),
        new Vector2(-1,0),
        new Vector2(0,1),
        new Vector2(0,-1)
    };

    /// <summary>
    /// Offset of connected GameObject from origin relative to current axis (ie. x is always left/right, z is always depth).
    /// </summary>
    [Tooltip("Offset of connected GameObject from origin relative to current axis (ie. x is always left/right, z is always depth).")]
    [SerializeField] private Vector3 _Offset;

    [SerializeField] private float _InvalidateLastThreshold = 0.707f;
    [SerializeField] private float _ValidateNewThreshold = 0.707f;
    [SerializeField] private float _TravelTime = 0.5f;
    [SerializeField] private bool _MoveWithPlayer = false;
    private int _LastAxis = 2;
    private int _LastRotationAmount;

    private Vector3 _TargetPosition;
    private Quaternion _TargetRotation;

    private Vector3 _StartPosition;
    private Quaternion _StartRotation;
    
    private float _CurrentTargetTime = 0.0f;
    
    private void SetTargetsByAxis(int axisIndex)
    {
        var axis = _TestAxes[_LastAxis];
        var axisV3 = axis.xoy();
        _TargetPosition = new Vector3(
            axis.x * _Offset.z + axis.y * _Offset.x,
            0,
            axis.x * _Offset.x + axis.y * _Offset.z
        );
        _TargetRotation = Quaternion.LookRotation(axisV3, Vector3.up);
        if (Mathf.Abs(Vector3.SignedAngle(transform.forward, axisV3, Vector3.up)) > 179)
        {
            transform.RotateAround(Vector3.zero, Vector3.up, 1f);
        }
        _StartPosition = transform.position.xoz();
        _StartRotation = transform.rotation;
        _CurrentTargetTime = 0.0f;
    }

    private void SetTransformByPlayerViewDirect()
    {
        CheckAxes();
        transform.position = _TargetPosition + _Offset.oyo();
        transform.rotation = _TargetRotation;
        _CurrentTargetTime = 1.0f;
    }
    
    private void Awake()
    {
        _HeadCameraTransform = FindObjectOfType<XROrigin>().GetComponentInChildren<Camera>().transform;
    }

    private void OnEnable()
    {
        SetTransformByPlayerViewDirect();
    }

    private void CheckAxes()
    {
        var _horizontalLook = _HeadCameraTransform.forward.xz().normalized;
        // if (Vector2.Dot(_horizontalLook, _TestAxes[_LastAxis]) > _InvalidateLastThreshold) return;
        for (var i = 0; i < _TestAxes.Length; i++)
        {
            if (Vector2.Dot(_horizontalLook, _TestAxes[i]) < _ValidateNewThreshold) continue;

            _LastAxis = i;
            SetTargetsByAxis(i);
            return;
        }
    }

    private void UpdateTransform()
    {
        if (_CurrentTargetTime >= 1) return;
        _CurrentTargetTime = Mathf.Clamp01(_CurrentTargetTime + Time.deltaTime / _TravelTime);
        var easedTime = Utility.Easings.EaseInOutSine(_CurrentTargetTime);
        transform.position = Vector3.Slerp(_StartPosition, _TargetPosition, easedTime) + _Offset.oyo();
        transform.rotation = Quaternion.Slerp(_StartRotation, _TargetRotation, easedTime);
    }
    
    private void Update()
    {
        if (_MoveWithPlayer)
        {
            CheckAxes();
            UpdateTransform();
        }
    }
}

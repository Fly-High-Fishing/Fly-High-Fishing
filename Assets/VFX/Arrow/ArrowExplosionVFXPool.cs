using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utility;

public class ArrowExplosionVFXPool : MonoBehaviour
{
    [SerializeField] private GameObject _ArrowExplodePrefab;
    [SerializeField] private int _InitialCapacity = 1;
    
    public static ObjectPool<ArrowExplodeVFX> Pool { get; private set; }

    private ArrowExplodeVFX CreateObject()
    {
        return Instantiate(_ArrowExplodePrefab, Vector3.zero, Quaternion.identity).GetComponent<ArrowExplodeVFX>();
    }

    private static void Lease(ArrowExplodeVFX obj)
    {
        
    }

    private static void Return(ArrowExplodeVFX obj)
    {
        
    }
    
    private void Start()
    {
        Pool = new ObjectPool<ArrowExplodeVFX>(_InitialCapacity, CreateObject, Lease, Return);
    }
}

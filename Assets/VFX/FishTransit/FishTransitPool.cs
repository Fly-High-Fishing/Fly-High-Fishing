using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utility;
using VFX;

public class FishTransitPool : MonoBehaviour
{
    [SerializeField] private GameObject _FishTransitPrefab;
    [SerializeField] private int _InitialCapacity = 4;
    
    public static ObjectPool<FishTransit> Pool { get; private set; }

    private FishTransit CreateObject()
    {
        return Instantiate(_FishTransitPrefab, Vector3.zero, Quaternion.identity).GetComponent<FishTransit>();
    }

    private static void Lease(FishTransit obj)
    {
        
    }

    private static void Return(FishTransit obj)
    {
        
    }
    
    private void Start()
    {
        Pool = new ObjectPool<FishTransit>(_InitialCapacity, CreateObject, Lease, Return);
    }

    
}

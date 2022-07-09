using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaughtFishManager : MonoBehaviour
{
    public static CaughtFishManager Instance { get; private set; }
    
    [SerializeField] private float _FishDestinationRadius;
    [SerializeField] private Transform _CaughtFishOrigin;

    [SerializeField] private Boids.Flock _CaughtFlock;
    public Boids.Flock CaughtFlock => _CaughtFlock;

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("CaughtFishManager Instance was already set. Only one instance should exist.");
            return;
        }

        Instance = this;
    }

    public static Vector3 GetFishDestination()
    {
        if (Instance == null) throw new NullReferenceException("No instance of CaughtFishManager exists in the scene.");
        return UnityEngine.Random.insideUnitSphere * Instance._FishDestinationRadius + 
               (Instance._CaughtFishOrigin ? Instance._CaughtFishOrigin.position : Instance.transform.position);
    }
}

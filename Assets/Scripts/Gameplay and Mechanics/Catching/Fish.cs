using System.Collections;
using System.Collections.Generic;
using Boids;
using UnityEngine;
using VFX;

public class Fish : MonoBehaviour, ICatchable
{
    [SerializeField] private int _ScoreValue;
    [SerializeField] private Color _Colour;
    private bool _IsCaught = false;
    
    public async void Catch()
    {
        if (_IsCaught) return;
        _IsCaught = true;
        Scoring.AddScore(_ScoreValue);

        var renderer = GetComponentInChildren<Renderer>();
        var collider = GetComponentInChildren<Collider>();
        renderer.enabled = false;
        collider.enabled = false;
        
        GetComponent<FlockMember>().Flock.RemoveAgent(gameObject);
        
        var vfx = FishTransitPool.Pool.Get();
        vfx.transform.position = transform.position;
        var destination = CaughtFishManager.GetFishDestination();
        await vfx.StartTransit(destination, _Colour);
        FishTransitPool.Pool.Return(vfx);

        CaughtFishManager.Instance.CaughtFlock.AddAgent(gameObject);
        
        transform.position = destination;
        renderer.enabled = true;
        collider.enabled = true;
    }
}

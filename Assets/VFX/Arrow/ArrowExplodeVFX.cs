using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.VFX;

public class ArrowExplodeVFX : MonoBehaviour, IPlayableVFX
{
    private VisualEffect _VFX;
    
    public event Action FinishedPlaying;

    private void Awake()
    {
        _VFX = GetComponent<VisualEffect>();
    }
    
    public async Task Play()
    {
        _VFX.Play();
    }
}

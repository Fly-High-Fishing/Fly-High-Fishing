using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public interface IPlayableVFX
{
    /// <summary>
    /// Invoked on completion of Play()
    /// </summary>
    public event Action FinishedPlaying;
    /// <summary>
    /// Play the VFX sequence and return an awaitable task for its completion.
    /// </summary>
    /// <returns></returns>
    Task Play();
}

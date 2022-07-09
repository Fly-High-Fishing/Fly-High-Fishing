using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;
using UnityEngine.XR.Interaction.Toolkit;
using Utility;

public class Arrow : XRGrabInteractable
{
    [Header("Arrow Properties")]
    [SerializeField] private float _Speed = 100.0f;
    [SerializeField] private bool _UseGravityInFlight = true;
    [Tooltip("Maximum range from _ArrowRangeOrigin the arrow may fly before despawning.")]
    [SerializeField] private float _MaxRangeBeforeDespawn = 20.0f;
    [Tooltip("Transform denoting the arrow's origin for range-based despawning.")]
    [SerializeField] private Transform _ArrowRangeOrigin;
    [Tooltip("Time from drop until the arrow despawns. Set negative to disable.")]
    [SerializeField] private float _UnheldTimeUntilDespawn = 3.0f;
    [Header("Visuals")]
    [Tooltip("Minimum distance from the camera to play _DespawnVFX. Set negative to disable VFX.")]
    [SerializeField] private float _MinDistanceFromPlayerToPlayVFX = 5.0f;

    public enum ArrowState
    {
        Unheld,
        Held,
        Disabled,
        InFlight
    }
    
    public event Action Despawned;

    private new Collider collider = null;
    private new Rigidbody rigidbody = null;
    private VisualEffect _TrailVFX;

    private float _CurrentUnheldTime = 0.0f;
    
    public ArrowState State { get; protected set; }

    protected override void Awake()
    {
        base.Awake();
        collider = GetComponentInChildren<Collider>();
        rigidbody = GetComponent<Rigidbody>();
        _TrailVFX = GetComponentInChildren<VisualEffect>();
        SetDisabled();
    }

    protected override void OnSelectEntering(SelectEnterEventArgs args)
    {
        SetHeld();
        // Make sure to do this
        base.OnSelectEntering(args);
    }

    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        // Make sure to do this
        base.OnSelectExited(args);

        // If it's a notch, launch the arrow
        if (args.interactor is Notch notch)
            Launch(notch);
        else
            SetUnheld();
    }

    private void Launch(Notch notch)
    {
        // Double-check incase the bow is dropped with arrow socketed
        if (!notch.IsReady) return;
        
        SetInFlight();
        ApplyForce(notch.PullMeasurer);
        
    }

    private void SetInFlight()
    {
        collider.isTrigger = true;
        State = ArrowState.InFlight;
        rigidbody.useGravity = _UseGravityInFlight;
        rigidbody.isKinematic = false;
        _TrailVFX.Play();
        gameObject.SetActive(true);
        _CurrentUnheldTime = 0.0f;
    }

    private void SetDisabled()
    {
        rigidbody.velocity = Vector3.zero;
        collider.isTrigger = false;
        State = ArrowState.Disabled;
        rigidbody.useGravity = false;
        _TrailVFX.Stop();
        gameObject.SetActive(false);
        _CurrentUnheldTime = 0.0f;
    }

    private void SetHeld()
    {
        rigidbody.velocity = Vector3.zero;
        collider.isTrigger = false;
        State = ArrowState.Held;
        rigidbody.useGravity = false;
        rigidbody.isKinematic = true;
        _TrailVFX.Stop();
        gameObject.SetActive(true);
        _CurrentUnheldTime = 0.0f;
    }
    
    private void SetUnheld()
    {
        collider.isTrigger = false;
        State = ArrowState.Unheld;
        rigidbody.useGravity = true;
        rigidbody.isKinematic = false;
        _TrailVFX.Stop();
        gameObject.SetActive(true);
    }

    private void ApplyForce(PullMeasurer pullMeasurer)
    {
        // Apply force to the arrow
        float power = pullMeasurer.PullAmount;
        Vector3 force = transform.forward * (power * _Speed);
        //rigidbody.velocity = force;
        rigidbody.AddForce(force, ForceMode.VelocityChange);
    }
    
    private void PlayExplosionVFX()
    {
        var vfx = ArrowExplosionVFXPool.Pool.Get();
        vfx.FinishedPlaying += () => { ArrowExplosionVFXPool.Pool.Return(vfx); };
        vfx.transform.position = transform.position;
        _ = vfx.Play();
    }
    
    /// <summary>
    /// Determine whether to despawn the arrow based on its distance from its origin.
    /// </summary>
    private void CheckForRangeDespawn()
    {
        var displacement = _ArrowRangeOrigin
            ? Vector3.SqrMagnitude(transform.position - _ArrowRangeOrigin.position)
            : Vector3.SqrMagnitude(transform.position);
        
        if (displacement <= Mathf.Pow(_MaxRangeBeforeDespawn, 2)) return;
        
        // TODO change this to distance from camera.
        if (_MinDistanceFromPlayerToPlayVFX > 0 && displacement > Mathf.Pow(_MinDistanceFromPlayerToPlayVFX, 2))
        {
            PlayExplosionVFX();
        }
        SetDisabled();
    }

    /// <summary>
    /// Dspawns arrow if left unheld for _UnheldTimeUntilDespawn seconds.
    /// </summary>
    private void ProgressUnheldDespawn()
    {
        if (State != ArrowState.Unheld) return;
        
        _CurrentUnheldTime += Time.deltaTime;
        if (_CurrentUnheldTime >= _UnheldTimeUntilDespawn)
        {
            SetDisabled();
        }
    }

    private void UpdateArrowFlight()
    {
        if (State != ArrowState.InFlight) return;
        transform.forward = rigidbody.velocity;
        CheckForRangeDespawn();
    }
    
    public override void ProcessInteractable(XRInteractionUpdateOrder.UpdatePhase updatePhase)
    {
        base.ProcessInteractable(updatePhase);
        
        switch (updatePhase)
        {
            case XRInteractionUpdateOrder.UpdatePhase.Fixed:
                break;
            case XRInteractionUpdateOrder.UpdatePhase.Dynamic:
                UpdateArrowFlight();
                ProgressUnheldDespawn();
                break;
        }
    }
}

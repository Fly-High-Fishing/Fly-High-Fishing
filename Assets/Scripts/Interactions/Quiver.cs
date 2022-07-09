using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(XRSimpleInteractable))]
public class Quiver : MonoBehaviour
{
    private XRSimpleInteractable _Interactablebase;
    
    [SerializeField] private Arrow _Arrow;
    [Tooltip("Whether or not using the quiver while the arrow is in flight will recall the arrow.")]
    [SerializeField] private bool _IsRecallableDuringFlight = false;
    [Tooltip("Whether or not using the quiver while the arrow is unheld (eg. on the ground) will recall it.")]
    [SerializeField] private bool _IsRecallableUnheld = false;

    private void Awake()
    {
        _Interactablebase = GetComponent<XRSimpleInteractable>();
    }
    
    private void OnEnable()
    {
        _Interactablebase.selectEntered.AddListener(TryRetrieveArrow);
    }

    private void TryRetrieveArrow(SelectEnterEventArgs args)
    {
        Debug.Log("TryRetrieve");
        var isArrowRetrievable = _Arrow.State == Arrow.ArrowState.Disabled || 
                                (_IsRecallableUnheld && _Arrow.State == Arrow.ArrowState.Unheld) || 
                                (_IsRecallableDuringFlight && _Arrow.State == Arrow.ArrowState.InFlight);
        if (!isArrowRetrievable) return;
        _Interactablebase.interactionManager.SelectEnter(args.interactorObject, _Arrow);
    }
}

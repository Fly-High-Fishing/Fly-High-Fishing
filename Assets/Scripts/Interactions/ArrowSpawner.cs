using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ArrowSpawner : XRBaseInteractable
{
    public GameObject arrowPrefab = null;

    protected override void Awake()
    {
        base.Awake();
        CreateArrow(transform);
    }

    protected override void OnEnable()
    {
        base.OnEnable();
        selectEntered.AddListener(CreateAndSelectArrow);
    }

    protected override void OnDisable()
    {
        base.OnDisable();
        selectEntered.RemoveListener(CreateAndSelectArrow);
    }

    private void CreateAndSelectArrow(SelectEnterEventArgs args)
    {
        //make the arrow, force it to the hand
        Arrow arrow = CreateArrow(args.interactor.transform);
        interactionManager.ForceSelect(args.interactor, arrow);
    }

    private Arrow CreateArrow(Transform parent)
    {
        //create the new arrow and return it
        GameObject arrowObj = Instantiate(arrowPrefab, parent.position, parent.rotation);
        return arrowObj.GetComponent<Arrow>();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ToggleRay : MonoBehaviour
{
    [SerializeField] XRRayInteractor leftRayInteractor;
    [SerializeField] XRRayInteractor rightRayInteractor;
    [SerializeField] XRInteractorLineVisual leftRayController;
    [SerializeField] XRInteractorLineVisual rightRayController;

    private bool raycastOff = true;

    public void HideControllerRay()
    {
        leftRayController.enabled = false;
        leftRayInteractor.enabled = false;
        rightRayController.enabled = false;
        rightRayInteractor.enabled = false;
    }

    public void ShowControllerRay()
    {
        leftRayController.enabled = true;
        leftRayInteractor.enabled = true;
        rightRayController.enabled = true;
        rightRayInteractor.enabled = true;
    }


    // Start is called before the first frame update
    void Start()
    {
        ToggleControllerRays();
    }

    private void Update()
    {
        if (!raycastOff)
        {
            ShowControllerRay();
        }
    }

    public void ToggleControllerRays()
    {
        raycastOff = !raycastOff;
        if (raycastOff)
        {
            HideControllerRay();
        }
        else
        {
            ShowControllerRay();
        }
    }
}

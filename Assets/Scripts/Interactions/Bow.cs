using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Bow : XRGrabInteractable
{
    private Notch notch = null;
    private Material _Material;
    private int _EmissionFactorID;
    
    protected override void Awake()
    {
        base.Awake();
        notch = GetComponentInChildren<Notch>();
        _Material = GetComponentInChildren<MeshRenderer>().material;
        _EmissionFactorID = Shader.PropertyToID("EmissionFactor");
    }

    protected override void OnEnable()
    {
        base.OnEnable();

        //Only notch an arrow if the bow is held
        selectEntered.AddListener(notch.SetReady);
        selectExited.AddListener(notch.SetReady);
        notch.PullMeasurer.Pulled.AddListener(UpdateEmissionFactor);
        _Material.SetFloat(_EmissionFactorID, notch.PullMeasurer.PullAmount);
    }

    protected override void OnDisable()
    {
        base.OnDisable();
        selectEntered.RemoveListener(notch.SetReady);
        selectExited.RemoveListener(notch.SetReady);
        notch.PullMeasurer.Pulled.RemoveListener(UpdateEmissionFactor);
    }

    private void UpdateEmissionFactor(Vector3 _, float amount)
    {
        _Material.SetFloat(_EmissionFactorID, amount);
    }

}

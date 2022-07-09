using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowRecaller : MonoBehaviour
{
    public float maxArrowFlightDistance = 20f;
    public Transform returnPoint = null;

    private GameObject obj = null;
    private Rigidbody rb = null;

    private bool isReturning = false;
    private Vector3 posWhenReturning;
    private float returnTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        obj = this.gameObject;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (returnPoint != null && Vector3.Distance(obj.transform.position, returnPoint.position) >= maxArrowFlightDistance && !isReturning)
        {
            ReturnStart();
        }

        if (isReturning)
        {
            ReturnUpdate();
        }
    }

    //Sets the last position of the arrow before it started returning
    private void ReturnStart()
    {
        posWhenReturning = obj.transform.position;
        rb.velocity = Vector3.zero;
        isReturning = true;
        returnTime = 0f;
    }

    //Updates the position of the arrow between the last position and the return point
    private void ReturnUpdate()
    {
        returnTime += Time.deltaTime;
        obj.transform.position = Vector3.Lerp(posWhenReturning, returnPoint.position, Mathf.Clamp01(returnTime));
        if (returnTime >= 1)
        {
            isReturning = false;
            rb.angularVelocity = Vector3.zero;
        }
    }

}

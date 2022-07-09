using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bowRespawner : MonoBehaviour
{
    [SerializeField]GameObject bow;
    public Transform resetPoint;
    Rigidbody rb;
    public float maxDistance = 50f;
    // Start is called before the first frame update
    void Start()
    {
        rb = bow.GetComponent<Rigidbody>();
        bow.transform.position = resetPoint.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(resetPoint.position, bow.transform.position) >= maxDistance)
        {
            bow.transform.position = resetPoint.position;
            rb.velocity = Vector3.zero;
        }
    }
}

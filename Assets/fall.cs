using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fall : MonoBehaviour
{   
    MeshRenderer visible;
    Rigidbody rb;
    [SerializeField]float wait=3f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        visible = GetComponent<MeshRenderer>();
        visible.enabled = false;
        rb.useGravity=false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time> wait)
        {
            visible.enabled = true;
            rb.useGravity=true;
        }
    }
}
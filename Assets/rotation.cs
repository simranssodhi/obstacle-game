using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{   [SerializeField]float xRot=0f;
    [SerializeField]float yRot=0.5f;
    [SerializeField]float zRot=0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xRot,yRot,zRot);
    }
}

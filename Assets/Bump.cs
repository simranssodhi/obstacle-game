using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bump : MonoBehaviour
{
     private void OnCollisionEnter(Collision other) {
        // when an object bumps into the fence, the event calls OnCollisionEnter function, the other is the object that collided with the wall
        if(other.gameObject.tag == "Player"){
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
     }
}

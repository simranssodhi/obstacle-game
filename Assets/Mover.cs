using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    [SerializeField]float moveSpeed=1;
    [SerializeField]float yValue=0f;  
    // Start is called before the first frame update
    void Start()
    {
       PrintInstruction();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void PrintInstruction()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Use WASD or arrow keys to control player movement.");
        Debug.Log("Reach the end of the obstacle course without hitting the walls.");
    }

    void Move()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue,yValue,zValue);
    }
}

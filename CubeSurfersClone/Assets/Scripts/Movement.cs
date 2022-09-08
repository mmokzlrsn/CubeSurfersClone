using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float forwardSpeed; //Z axis
    [SerializeField] private float horizontalSpeed; //X axis
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalAxis = Input.GetAxis("Horizontal") * horizontalSpeed * Time.deltaTime;
        this.transform.Translate(horizontalAxis, 0, forwardSpeed * Time.deltaTime); //player will always moves forwards and user will only move the player left or right

        
    }
}

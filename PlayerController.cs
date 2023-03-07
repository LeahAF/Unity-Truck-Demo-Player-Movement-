using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20f;
    private float turnSpeed = 45f;
    private float horizontalInput;
    private float fowardInput;

    void Update()
    {
        //Move the vehicle forward

        //Gets horizontal and vertical input from player (WASD)
        horizontalInput = Input.GetAxis("Horizontal");
        fowardInput = Input.GetAxis("Vertical");

        //Controls the speed, vehicle direction and movement of the player
        transform.Translate(Vector3.forward * Time.deltaTime * speed * fowardInput);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput *  Time.deltaTime);
    }
}

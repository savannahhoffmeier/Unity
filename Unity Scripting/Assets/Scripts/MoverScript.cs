using System;
using UnityEngine;

public class MoverScript : MonoBehaviour
{
    public CharacterController controller;
    private Vector3 moveDirection;
    private float yDirection;
    public float moveSpeed = 5f, gravity = -9.81f, jumpForce = 10f;
    private void Update() //update runs every frame
    {
        var moveSpeedInput = moveSpeed * Input.GetAxis("Horizontal");
        
        moveDirection.Set(moveSpeedInput,0,0);

        yDirection += gravity * Time.deltaTime;
        
        if (controller.isGrounded && moveDirection.y< 0)
        {
            yDirection = 1f;
        }

        if (Input.GetButtonDown("Jump"))
        {
            yDirection = jumpForce;
        }
        
        var movement = moveDirection * Time.deltaTime;
        controller.Move(movement);
    }
}
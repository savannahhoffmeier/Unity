using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class ReviewCharacterMover : MonoBehaviour
{
 
    private CharacterController player;
    public float moveSpeed = 5f, gravity = -9.81f, jumpForce = 10f;
    private Vector3 moveDirection;
    private float yDirection;
    private void Start()
    {
        player = GetComponent<CharacterController>();
    }

    private void Update()
    {
        var moveSpeedInput = moveSpeed * Input.GetAxis("Horizontal");
        moveDirection.Set(moveSpeedInput,yDirection,0);
        yDirection += gravity * Time.deltaTime;
        if(player.isGrounded&& moveDirection.y<0)
        {
            yDirection = -1f;
        }
        var moveSpeedInput2 = moveSpeed * Input.GetAxis("Vertical");
        moveDirection.Set(moveSpeedInput2,yDirection,0);
        yDirection += gravity * Time.deltaTime;
        if(player.isGrounded&& moveDirection.y<0)
        {
            yDirection = -1f;
        }

        if (Input.GetButtonDown("Jump"))
        {
            yDirection = jumpForce;
        }

        var movement = moveDirection * Time.deltaTime;
            player.Move(movement);
    }
}

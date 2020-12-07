using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
[RequireComponent(typeof(CharacterController))]
public class CharacterMover_1 : MonoBehaviour
{
    private CharacterController _controller;
    public float moveSpeed = 5f, gravity = -9.81f, jumpForce = 10f;
    private Vector3 moveDirection;
    private float yDirection;
    private void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        var moveSpeedInput = moveSpeed * Input.GetAxis("Horizontal");
        moveDirection.Set(moveSpeedInput,yDirection,0);
        yDirection += gravity * Time.deltaTime;
        if(_controller.isGrounded&& moveDirection.y<0)
        {
            yDirection = -1f;
        }

        if (Input.GetButtonDown("Jump"))
        {
            yDirection = jumpForce;
        }

        var movement = moveDirection * Time.deltaTime;
        _controller.Move(movement);
    }
}
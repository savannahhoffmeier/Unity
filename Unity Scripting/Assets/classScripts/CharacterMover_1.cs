using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(CharacterController))]
public class CharacterMover_1 : MonoBehaviour
{
    CharacterController controller;
    public float moveSpeed = 5f, gravity = -8.81f, jumpForce = 10f;

    private Vector3 moveDirection;
    private float yDirection;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        var moveSpeedInput = moveSpeed * Input.GetAxis("Horizontal");
        moveDirection.Set(moveSpeedInput,yDirection,0);
    
        yDirection += gravity * Time.deltaTime;
    
        if(controller.isGrounded && moveDirection.y<0)
        {
            yDirection = -1f;
        }
    }
}
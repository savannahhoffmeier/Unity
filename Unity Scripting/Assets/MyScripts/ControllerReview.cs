using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class ControllerReview : MonoBehaviour
{
    public float speed = 14f;
    private Rigidbody rig;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    private Vector3 moveDirection= Vector3.zero;
    private CharacterController controller;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float haxis = Input.GetAxis("Horizontal");
        float vaxis = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(haxis, 0, vaxis) * speed * Time.deltaTime;
        rig.MovePosition(transform.position+movement);

        if (controller.isGrounded && Input.GetButton("Jump"))
        {
            moveDirection.y = jumpSpeed;
        }

        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
}

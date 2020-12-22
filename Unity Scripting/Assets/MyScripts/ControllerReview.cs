using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.VersionControl;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class ControllerReview : MonoBehaviour
{
    public float speed = 3.0F, gravity = -9.81f;
    public float rotateSpeed = 3.0F;
    private Vector3 moveDirection;
    private float yDirection;
    public float jumpHeight = 7f;
    public bool isGrounded;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();

        // Rotate around y - axis
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);

        // Move forward / backward
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        float curSpeed = speed * Input.GetAxis("Vertical");
        controller.SimpleMove(forward * curSpeed);
        yDirection += gravity * Time.deltaTime;

        if (isGrounded)
        {
            if (Input.GetButtonDown("Jump"))
            {
                rb.AddForce(Vector3.up * jumpHeight);
            }
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }

    }
}

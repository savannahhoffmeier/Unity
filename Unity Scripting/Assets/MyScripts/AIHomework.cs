using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

[RequireComponent(typeof(Rigidbody))]
public class AIHomework : MonoBehaviour
{
    public float jumpHeight = 7f;
    public bool isGrounded;
    public float NumberJumps =8f;
    public float maxJumps = 2f;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (NumberJumps>maxJumps-1)
        {
            isGrounded = false;
        }

        if (isGrounded)
        {
            if (Input.GetButtonDown("Jump"))
            {
                rb.AddForce(Vector3.up*jumpHeight);
                NumberJumps += 1;
            }
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        isGrounded = true;
        NumberJumps = 2;
    }
}

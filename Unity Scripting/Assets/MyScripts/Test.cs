using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Test : MonoBehaviour
{
    private Rigidbody rb;
    private GameObject collision;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(Input.GetKeyDown("Space"))
        {
            rb.AddForce(Vector3.up);
        }
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (collision.gameObject.tag=="Enemy")
        {
            Destroy(gameObject);
        }
    }
}

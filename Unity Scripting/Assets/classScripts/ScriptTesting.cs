using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class ScriptTesting : MonoBehaviour
{
    private CharacterController player;
    public float Movement = 6f, gravity = 30f, jumpForce = 30;
    private Vector3 moving;
    private float yDirect;

    private void Start()
    {
        player = GetComponent<CharacterController>();
    }

    private void Update()
    {
        var moveSpeedInput = Movement * Input.GetAxis("Horizontal");
        moving.Set(moveSpeedInput, yDirect, 0);
        yDirect += gravity * Time.deltaTime;
        if (player.isGrounded && moving.y < 0)
        {
            yDirect = -1f;
        }

        var moveSpeed = Movement * Input.GetAxis("Vertical");
        moving.Set(moveSpeedInput, yDirect, 3);
        yDirect += gravity * Time.deltaTime;
        if (player.isGrounded && moving.y < 0)
        {
            yDirect = -1f;
        }
    }
}

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
    private CharacterController controller;
    private Vector3 playerV;
    private bool gPlayer;
    private float playerSpeed = 2.0f;
    private float jumpHeight = 1.0f;
    private float gravityValue = -9.81f;

    private void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
    }

    void Update()
    {
        gPlayer = controller.isGrounded;
        if (gPlayer && playerV.y < 0)
        {
            playerV.y = 0f;
        }

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * playerSpeed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        // Changes the height position of the player..
        if (Input.GetButtonDown("Jump") && gPlayer)
        {
            playerV.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }

        playerV.y += gravityValue * Time.deltaTime;
        controller.Move(playerV * Time.deltaTime);
    }
}
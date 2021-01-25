using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.VersionControl;
using UnityEngine;


public class ControllerReview : MonoBehaviour
{
  private CharacterController controller;
      private Vector3 Velocity;
      private bool Player;
      private float Speed = 2.0f;
      private float jumpHeight = 1.0f;
      private float gravityValue = -9.81f;
  
      private void Start()
      {
          controller = gameObject.AddComponent<CharacterController>();
      }
  
      void Update()
      {
          Player = controller.isGrounded;
          if (Player && Velocity.y < 0)
          {
              Velocity.y = 0f;
          }
  
          Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
          controller.Move(move * Time.deltaTime * Speed);
  
          if (move != Vector3.zero)
          {
              gameObject.transform.forward = move;
          }
  
          // Changes the height position of the player..
          if (Input.GetButtonDown("Jump") && Player)
          {
              Velocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
          }
  
          Velocity.y += gravityValue * Time.deltaTime;
          controller.Move(Velocity * Time.deltaTime);
      }
}

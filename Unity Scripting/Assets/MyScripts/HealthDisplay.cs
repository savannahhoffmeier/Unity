 using System;
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.UI;

 public class HealthDisplay : MonoBehaviour
 {
     public float speed = 5f;
     public float jumpSpeed = 5000f;

     Rigidbody rb;
     bool canJump;

     void Start()
     {
         rb = GetComponent<Rigidbody>();
     }


     private void OnCollisionEnter(Collision other)
     {
         if (other.gameObject.tag == "Floor")
             if (other.gameObject.tag == "Floor")
             {
                 canJump = true;
             }
     }

     private void OnCollisionExit(Collision other)
     {
         if (other.gameObject.tag == "Floor")
         {
             canJump = false;
         }
     }

     private void Update()
     {
         if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
         {
             rb.AddForce(0f, 0f, speed * Time.deltaTime);
         }

         if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
         {
             rb.AddForce(0f, 0f, -speed * Time.deltaTime);
         }

         if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
         {
             rb.AddForce(-speed * Time.deltaTime, 0f, 0f);
         }

         if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
         {
             rb.AddForce(speed * Time.deltaTime, 0f, 0f);
         }
         if (Input.GetKey(KeyCode.Space) & canJump)
         {
             rb.AddForce(0f, jumpSpeed * Time.deltaTime, 0f);
         }
         
     }
 }

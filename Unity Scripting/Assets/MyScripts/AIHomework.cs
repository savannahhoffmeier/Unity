using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;
public class AIHomework : MonoBehaviour
{
   public float jumpingHeight = 7f;
   public bool Grounded;
   
   private Rigidbody rb;
   
   void Start()
   {
    rb = GetComponent<Rigidbody>();
   }
   
   void Update()
   {
      if (Grounded)
      {
         if (Input.GetButtonDown("Jump"))
         {
             rb.AddForce(Vector3.up * jumpingHeight);
         }
      }
   }
   
   void OnCollisionEnter(Collision other)
   {
       if (other.gameObject.tag == "Ground")
       {
           Grounded = true;
       }
   }
   
   void OnCollisionExit(Collision other)
   {
       if (other.gameObject.tag == "Ground")
       {
           Grounded = false;
       }
   }
}

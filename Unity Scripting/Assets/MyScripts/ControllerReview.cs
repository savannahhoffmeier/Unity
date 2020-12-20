using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.VersionControl;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class ControllerReview : MonoBehaviour
{
public float speed = 3.0F;
public float rotateSpeed = 3.0F, gravity = 10f, jump=10f;
public float ydirect;

     
 
     void Update()
     {
         CharacterController controller = GetComponent<CharacterController>();
 
         // Rotate around y - axis
         transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);
 
         // Move forward / backward
         Vector3 forward = transform.TransformDirection(Vector3.forward);
         float curSpeed = speed * Input.GetAxis("Vertical");
         controller.SimpleMove(forward * curSpeed);
         
         if (Input.GetButtonDown("jump"))
         {
             ydirect=jump;
         }
     }
    
    
}

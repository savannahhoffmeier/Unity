using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.VersionControl;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class ControllerReview : MonoBehaviour
{
public float speed = 3.0F,gravity=-9f,jumpForce=30f;
public float rotateSpeed = 3.0F;
private Vector3 moveDirection;


void Update()
     {
         CharacterController controller = GetComponent<CharacterController>();
 
         // Rotate around y - axis
         transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);
 
         // Move forward / backward
         Vector3 forward = transform.TransformDirection(Vector3.forward);
         float curSpeed = speed * Input.GetAxis("Vertical");
         controller.SimpleMove(forward * curSpeed);

         var movespeedInput = speed * Input.GetAxis("Horizontal");
         moveDirection.Set(movespeedInput,gravity,0);

         if (Input.GetButtonDown("Jump"))
         {
            moveDirection.y=jumpForce ;
         }
     }
}

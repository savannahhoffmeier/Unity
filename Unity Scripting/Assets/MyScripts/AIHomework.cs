using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;
[RequireComponent(typeof(Rigidbody))]
public class AIHomework : MonoBehaviour
{
   private Rigidbody rigidb;
   private Vector3 usingforce;
   private float pauseTime;

   private IEnumerator Start()
   {
      rigidb = GetComponent<Rigidbody>();
      yield return new WaitForSeconds(pauseTime);
      rigidb.AddForce(usingforce);
   }

   private void jump()
   {
      if (Input.GetKeyDown(KeyCode.Space))
      {
         rigidb.AddForce(usingforce);
      }
   }
}

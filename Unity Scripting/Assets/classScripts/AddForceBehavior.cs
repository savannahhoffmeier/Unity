using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class AddForceBehavior : MonoBehaviour
{
 private Rigidbody rigid;
 public Vector3 forces;
 public float holdTime=3f;

 private IEnumerator Start()
 {
  rigid = GetComponent<Rigidbody>();
  yield return new WaitForSeconds(holdTime);
  rigid.AddForce(forces);
  rigid = GetComponent<Rigidbody>();
  yield return new WaitForSeconds(holdTime);
  rigid.AddForce(forces);
  rigid = GetComponent<Rigidbody>();
  yield return new WaitForSeconds(holdTime);
  rigid.AddForce(forces);
  rigid = GetComponent<Rigidbody>();
  yield return new WaitForSeconds(holdTime);
  rigid.AddForce(forces);
 }
}

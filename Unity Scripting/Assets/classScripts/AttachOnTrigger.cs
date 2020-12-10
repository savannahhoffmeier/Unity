using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachOnTrigger : MonoBehaviour
{
  private void OnTriggerEnter(Collider other)
  {
    transform.parent = other.transform;
  }

  private void OnTriggerExit(Collider other)
  {
    transform.parent = null;
  }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
 public int score;

 private void OnTriggerEnter(Collider other)
 {
  score++
 }
}

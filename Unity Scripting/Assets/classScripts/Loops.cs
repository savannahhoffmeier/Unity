using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
 private int Enemies = 3;
 private GameObject Victim;

 private void Start()
 {
  for (int i = 0; i < Enemies; i++)
  {
   Debug.Log("Prepare to Battle!");
  }

  while (Victim)
  {
   Debug.Log("Save Me!");
  }
  String[] strings= new string[4];
  strings[1] = "Upgrade 1";
  strings[2] = "Upgrade 2";
  strings[3] = "Upgrade 3";
  strings[4] = "Upgrade 4";

  foreach (string item in strings)
  {
   print(item);
  }
 }
}

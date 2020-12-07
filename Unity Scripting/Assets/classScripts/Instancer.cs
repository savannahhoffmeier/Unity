using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instancer : MonoBehaviour
{
   public GameObject prefab;
   public float delay = 2f;

   private IEnumerator Start()
   {
      while (true)
      {
         yield return new WaitForSeconds(delay);
         Instantiate(prefab);
      }
   }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTest : MonoBehaviour
{
public Color colorIni = Color.white;
     public Color colorFin = Color.red;
     public float duration = 3f;
     Color lerpedColor = Color.white;
 
     private float t=0;
     private bool flag; 
 
     Renderer _renderer;
     
     void Start () {
         _renderer=GetComponent<Renderer>(); 
     }
     
     void Update() {
         lerpedColor = Color.Lerp(colorIni, colorFin,  t);
         _renderer.material.color = lerpedColor;
 
         if (flag == true) {
             t -= Time.deltaTime/duration;
             if (t < 0.01f)
                 flag = false;
         } else {
             t += Time.deltaTime/duration;
             if (t > 0.99f)
                 flag = true;
         }
     }
}

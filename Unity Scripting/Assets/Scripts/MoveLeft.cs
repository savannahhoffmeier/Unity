using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
  public float speed = 3f;
  public BoolData gameOver;

  private void Update()
  {
    if (gameOver.value == false)
    {
      transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
    
  }
}

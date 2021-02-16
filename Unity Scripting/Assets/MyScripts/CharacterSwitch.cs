﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

[RequireComponent(typeof(Random))]

public class CharacterSwitch : MonoBehaviour
{
    bool canPlayerMove = true;
  
    public float speed = 0.0f;
  
    void FixedUpdate()
    {
        float moveHorizontal = -Input.GetAxisRaw("LeftJoyStickHorizontal");
        float moveVertical = Input.GetAxisRaw("LeftJoyStickVertical");
  
        if (canPlayerMove)
        {
            Vector3 movement = new Vector3(moveVertical, 0.0f, moveHorizontal);
  
            if (movement != Vector3.zero)
            {
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), 0.15F);
            }
  
            transform.Translate(movement * speed * Time.deltaTime, Space.World);
        }
    }
}

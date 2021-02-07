using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

[RequireComponent(typeof(Random))]

public class CharacterSwitch : MonoBehaviour
{
    private int rNumber;
    public new Light light;
    public float redo = 2f;
    private float time = 0;
 
    private void Start()
    {
        light = gameObject.GetComponent<Light>();
        rNumber = Random.Range(1, 4);
    }
    private void Update()
    {
        time += Time.deltaTime ;
        if (time >= redo)
        {
            switch (rNumber)
            {
                case 0:
                    break;
                case 1:
                    light.color = Color.blue;
                    Debug.Log("Color switched to blue!");
                    break;
                case 2:
                    light.color = Color.red;
                    Debug.Log("Color switched to red!");
                    break;
                case 3:
                    light.color = Color.green;
                    Debug.Log("Color switched to green!");
                    break;
            }
            time = 0f;
            rNumber = Random.Range(1, 4);
        }
    }
}

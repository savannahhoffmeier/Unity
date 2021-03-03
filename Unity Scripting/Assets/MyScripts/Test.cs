using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Test : MonoBehaviour
{
    public GameObject Arrow;
    public GameObject Bow;
    public static int movespeed = 3;
    public Vector3 userDirection = Vector3.down;
    
    void Start()
    {
     (Arrow) = GameObject.Find("Arrow"); 
     (Bow) = GameObject.Find("Bow"); 
     Arrow.transform.position = Bow.transform.position; 
    }
    void Update()
    {
        transform.Translate(userDirection * movespeed * Time.deltaTime);
        
        if (Input.GetMouseButtonDown(0)) {
            gameObject.active = true;
        }
        if (Input.GetMouseButtonDown(1)) {
            gameObject.active = false;
        }

        if (Input.GetButtonDown("Jump"))
        {
            Destroy(gameObject);
        }
    }
    
}

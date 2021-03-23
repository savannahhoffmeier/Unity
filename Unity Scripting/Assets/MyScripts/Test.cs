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
    private float MHits=30f;
    private float Chits=20f;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)==true)
        {
            Chits = -5f;
            transform.localScale=new Vector3(Chits/MHits,1f,1f);
        }
    }
}
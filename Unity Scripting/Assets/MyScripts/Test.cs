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
    private void OnTriggerEnter(Collider other)
    {
        transform.parent = other.transform;
    }

    private void OnTriggerExit(Collider other)
    {
        transform.parent = null;
    }
}

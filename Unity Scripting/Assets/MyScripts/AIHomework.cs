using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

[RequireComponent(typeof(Rigidbody))]
public class AIHomework : MonoBehaviour
{
    public float score =12;
    private void OnTriggerEnter(Collider other)
    {
        transform.parent = other.transform;
    }

    private void OnTriggerExit(Collider other)
    {
        transform.parent = null;
    }

    private void Start()
    {
        if (score>12)
        {
            score++;
        }
    }
}

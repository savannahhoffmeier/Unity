using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(Rigidbody))]

public class Review : MonoBehaviour
{
    private Rigidbody _rigidbody;
    public Vector3 forces, forces2;
    public float holdTime = 3f;
    public int counter = 10;
    public bool canRun;
    private IEnumerator Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        while (counter>0)
        {
            yield return new WaitForSeconds(holdTime);
            _rigidbody.AddForce(forces);
            counter--;
        }
        while (canRun)
        {
            yield return new WaitForSeconds(holdTime);
            _rigidbody.AddForce(forces2);
            counter--;
        }
    }
}

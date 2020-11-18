using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AIHomework : MonoBehaviour
{
    private NavMeshAgent Spy;
    private Transform destination;
    private bool patrol;
    private int i = 0;

    public List<Transform> patrolPoints;

    private void Start()
    {
        Spy = GetComponent<NavMeshAgent>();
    }

    private void OnTriggerEnter(Collider other)
    {
        patrol = false;
        destination = other.transform;
    }

    private void OnTriggerExit(Collider other)
    {
        patrol = true;
    }
    

    private void Update()
    {
        Spy.destination = destination.position;
        if (!patrol) return;
        {
            destination = patrolPoints[i];
        }
    }
}

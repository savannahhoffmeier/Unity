
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AIBehavior : MonoBehaviour
{
  private NavMeshAgent agent;
  public Transform player;
  public Transform destination;
  public List<Transform> patrolPoints;
  private bool CanControl;
  private int i = 0;
  private void Start()
  {
    agent = GetComponent<NavMeshAgent>();
    destination = transform;
  }

  private void OnTriggerEnter(Collider other)
  {
    destination = other.transform;
  }

  private void OnTriggerExit(Collider other)
  {
    destination = transform;
  }

 
  private void Update()
  {
    agent.destination = player.position;
    if (!CanControl) return;
    
    if (!agent.pathPending && agent.remainingDistance < 0.5f)
    {
      destination= patrolPoints[i];
     i = (i + 1) % patrolPoints.Count;
    }
  }
}


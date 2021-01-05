using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(NavMeshAgent))]
public class AIHomework : MonoBehaviour
{
  public NavMeshAgent agent;
  public Transform player;
  public LayerMask whatIsGround, whatIsPlayer;
  
  public Vector3 walkPoint;
  private bool walkPointSet;
  public float walkPointRange;
  public float timeBetweenAttacks;
  private bool alreadyAttacked;

  public float sightRange, attackRange;
  public bool playerInSightRange, playInAttackRange;

  private void Awake()
  {
    player = GameObject.Find("PlayerObj").transform;
    agent = GetComponent<NavMeshAgent>();
  }

  private void Patroling()
  {
    
  }

  private void ChasePlayer()
  {
    
  }

  private void AttackPlayer()
  {
    
  }
}

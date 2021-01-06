using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

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
  public bool playerInSightRange, playerInAttackRange;

  private void Awake()
  {
    player = GameObject.Find("PlayerObj").transform;
    agent = GetComponent<NavMeshAgent>();
  }

  private void Update()
  {
    playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
    playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);
    if (!playerInSightRange && !playerInAttackRange) Patroling();
    if (playerInSightRange && !playerInAttackRange) ChasePlayer();
    if (playerInAttackRange && playerInSightRange) AttackPlayer();
  }

  private void Patroling()
  {
    if (!walkPointSet) SearchWalkPoint();
    if (walkPointSet)
    {
      agent.SetDestination(walkPoint);
    }

    Vector3 distanceToWalkPoint = transform.position - walkPoint;
  }

  private void SearchWalkPoint()
  {
    float randomZ = Random.Range(-walkPointRange, walkPointRange);
    float randomx = Random.Range(-walkPointRange, walkPointRange);
    
    walkPoint= new Vector3(transform.position.x+randomx, transform.position.y, transform.position.z + randomZ);
    if (Physics.Raycast(walkPoint, -transform.up, 2f, whatIsGround))
    {
      walkPointSet = true;
    }
  }
  private void ChasePlayer()
  {
    
  }

  private void AttackPlayer()
  {
    
  }
}

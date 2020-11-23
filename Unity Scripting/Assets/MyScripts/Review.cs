using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class Review : MonoBehaviour
{
 public Color skinColor = Color.blue;
 private NavMeshAgent Baby;
 private Transform destination;
 private bool patrol;
 private int i = 0;
 public List<Transform> patrolPoints;
 private void Start()
 {
  Baby = GetComponent<NavMeshAgent>();
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
  Baby.destination = destination.position;
  if (!patrol) return;
  {
   destination = patrolPoints[i];
  }
 }

}

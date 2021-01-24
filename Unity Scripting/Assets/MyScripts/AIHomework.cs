using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;
[RequireComponent(typeof(Rigidbody))]
public class AIHomework : MonoBehaviour
{
    public Transform player;
    private static Animator anime;

    private void Start()
    {
        anime = GetComponent<Animator>();
    }

    private void Update()
    {
        Vector3 direction = player.position - this.transform.position;
        float angle = Vector3.Angle(direction,this.transform.forward);
        if (Vector3.Distance(player.position,this.transform.position)<10&&angle<30)
        {
            direction.y = 0;
            
            this.transform.rotation=Quaternion.Slerp(this.transform.rotation,Quaternion.LookRotation(direction), 0.1f);
        }
    }
}

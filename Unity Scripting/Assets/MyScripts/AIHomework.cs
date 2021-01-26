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
        float angle = Vector3.Angle(direction, this.transform.forward);
        if (Vector3.Distance(player.position, this.transform.position) < 10 && angle < 30)
        {
            direction.y = 0;

            this.transform.rotation =
                Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.1f);
            anime.SetBool("isIdle", false);
            if ((direction.magnitude > 5))
            {
                this.transform.Translate(0, 0, 0.10f);
                anime.SetBool("isRunning", true);
                anime.SetBool("isAttacking", false);
                anime.SetBool("isTalking", false);
                anime.SetBool("isIdle2", false);

            }
            else
            {
                anime.SetBool("isRunning", false);
                anime.SetBool("isAttacking", true);
                anime.SetBool("isTalking", false);
                anime.SetBool("isIdle2", false);
            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                anime.SetBool("isTalking", true);
            }
        }
    }
}

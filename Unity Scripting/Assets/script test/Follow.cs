﻿using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Follow : MonoBehaviour
{
    public float attackSpeed = 4;
    public float attackDistance;
    public float bufferDistance;
    public GameObject player;

    Transform playerTransform;

    void GetPlayerTransform()
    {
        if (player != null)
        {
            playerTransform = player.transform;
        }
        else
        {
            Debug.Log("Player not specified in Inspector");
        }
    }

   
    void Start()
    {
        GetPlayerTransform();
    }

    // Update is called once per frame
    void Update()
    {
        var distance = Vector3.Distance(playerTransform.position, transform.position);
        
        if (distance <= attackDistance)
        {
            if (distance >= bufferDistance)
            {
                transform.position += transform.forward * attackSpeed * Time.deltaTime;
            }
        }
    }
}
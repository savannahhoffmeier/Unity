using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class WitchShooting : MonoBehaviour
{
    public GameObject bullet;
    public Transform target;
    private float fireRate;
    private float nextFire;

    private void Start()
    {
        fireRate = 1f;
        nextFire = Time.time;
    }

    private void Update()
    {
        LookAt();
        if (Time.time > nextFire)
        {
            Instantiate(bullet, transform.position, transform.rotation);
            nextFire = Time.time + fireRate;
        }
        
    }

    private void LookAt()
    {
        transform.LookAt(target);
    }
}

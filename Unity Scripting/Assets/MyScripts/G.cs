using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;


public class G : MonoBehaviour
{
    public ParticleSystem muzzleFlash;
    public float damage = 10f;
    public float range = 100f;
    public Camera fpsCam;
    public GameObject impacteffect;
    public float impactforce = 30f;
    public float fireRate = 15f;
    private float nextTimeFire = 0f;
    private void Update()
    {
        if (Input.GetButton("Fire1")&& Time.time>=nextTimeFire)
        {
            nextTimeFire = Time.time + 1f / fireRate;
            Shoot();
        }
    }

    void Shoot()
    {
        muzzleFlash.Play();
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position,fpsCam.transform.forward,out hit,range))
        {
            Debug.Log(hit.transform.name);
            Target target = hit.transform.GetComponent<Target>();
            if (target !=null)
            {
                target.TakeDamage(damage);
            }

            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal*impactforce);
            }
            GameObject impactGo =Instantiate(impacteffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impactGo);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Test : MonoBehaviour
{
    public enum ShootState {
        Ready,
        Shoot,
        Reload
    }
    
    private float muzzleOffset;
    [Header("Magazine")]
    public GameObject round;
    public int ammo;
    [Range(0.5f, 10)] public float reloadTime;
    private int remainingAmmo;
    [Header("Shooting")]
    [Range(0.25f, 25)] public float fireRate;
    public int roundsPerShot;
    [Range(0.5f, 100)] public float roundSpeed;
    [Range(0, 45)] public float maxRoundVariation;
    private ShootState shootState = ShootState.Ready;
    private float nextShootTime = 0;

    void Start() {
        muzzleOffset = GetComponent<Renderer>().bounds.extents.z;
        remainingAmmo = ammo;
    }
    void Update() {
        switch(shootState) {
            case ShootState.Shoot:
                
                if(Time.time > nextShootTime) {
                    shootState = ShootState.Ready;
                }
                break;
            case ShootState.Reload:
               
                if(Time.time > nextShootTime) {
                    remainingAmmo = ammo;
                    shootState = ShootState.Ready;
                }
                break;
        }
    }
    public void Shoot() {
        // Checks that the gun is ready to shoot
        if(shootState == ShootState.Ready) {
            for(int i = 0; i < roundsPerShot; i++) {
                // Instantiates the round at the muzzle position
                GameObject spawnedRound = Instantiate(
                    round,
                    transform.position + transform.forward * muzzleOffset,
                    transform.rotation
                );

                // Add a random variation to the round's direction
                spawnedRound.transform.Rotate(new Vector3(
                    Random.Range(-1f, 1f) * maxRoundVariation,
                    Random.Range(-1f, 1f) * maxRoundVariation,
                    0
                ));

                Rigidbody rb = spawnedRound.GetComponent<Rigidbody>();
                rb.velocity = spawnedRound.transform.forward * roundSpeed;
            }

            remainingAmmo--;
            if(remainingAmmo > 0) {
                nextShootTime = Time.time + (1 / fireRate);
                shootState = ShootState.Shoot;
            } else {
                Reload();
            }
        }
    }

    /// Attempts to reload the gun
    public void Reload() {
        // Checks that the gun is ready to be reloaded
        if(shootState == ShootState.Ready) {
            nextShootTime = Time.time + reloadTime;
            shootState = ShootState.Reload;
        }
    }

}
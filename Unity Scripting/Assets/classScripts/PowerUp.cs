using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject PowerupGameObject;
    public int Powerup;

    private void OnTriggerEnter(Collider other)
    {
        {
            Powerup++;
        }
    }
}

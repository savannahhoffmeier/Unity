using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoInc : MonoBehaviour
{
    public int ammo;

    private void OnTriggerEnter(Collider other)
    {
        ammo++;
            print(ammo);
    }
}

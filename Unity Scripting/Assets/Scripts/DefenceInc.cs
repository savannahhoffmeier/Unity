using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenceInc : MonoBehaviour
{
    public int defence;

    private void OnTriggerEnter(Collider other)
    {
        defence++;
        print(defence);
    }
}

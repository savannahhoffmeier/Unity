using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class G : ScriptableObject
{
    public int value;
    public UnityEvent powerUpEvent;

    private void OnTriggerEnter(Collider other)
    {
        value++;
        
        powerUpEvent.Invoke();
    }
}

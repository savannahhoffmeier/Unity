using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoolData : MonoBehaviour
{
    public bool value;
    public void UpdateValue(bool newValue)
    {
        value = newValue;
        Debug.Log("Game Over");
    }
}
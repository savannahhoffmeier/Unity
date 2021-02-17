using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using Random = UnityEngine.Random;
[CreateAssetMenu]

[RequireComponent(typeof(Rigidbody))]
public class AIHomework : MonoBehaviour
{
    public List<string> value;
    private int indexer = 0;

    private void OnEnable()
    {
        indexer = 0;
    }

    public void UpdateText(Text txt)
    {
        txt.text = value[indexer];
        indexer = (indexer + 1) % value.Count;
    }
}

using System.Runtime.InteropServices;
using UnityEngine;

public Color redcolor;
public Color bluecolor;

void OnTriggerEnter(Collider other);

if (other.gameObject.compareTag("Player1"))
{
Debug.Log("Made Contact")
    transform.GetComponent<Render>().material.color=redcolor;
}
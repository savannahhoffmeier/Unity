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
    public List<Transform> collectedTransforms;
    public Sprite art;
    public Color artColor;

    public void Collect(Transform obj)
    {
        collectedTransforms.Add(obj);
    }

    public void PrintCollection()
    {
        foreach (var obj in collectedTransforms)
        {
            Debug.Log(obj);   
        }
    } }
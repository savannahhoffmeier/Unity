using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour
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
    }
}

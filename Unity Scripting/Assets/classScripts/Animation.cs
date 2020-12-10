using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Animator))]
public class Animation : MonoBehaviour
{
    private Animator animation;
    void Start()
    {
        animation=GetComponent<Animator>();
    }
    
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            animation.SetTrigger("Jump");
        }
    }
}

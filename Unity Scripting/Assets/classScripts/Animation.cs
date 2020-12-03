using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Animator))]
public class Animation : MonoBehaviour
{
    private Animator anims;
    // Start is called before the first frame update
    void Start()
    {
        anims=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            anims.SetTrigger("Jump");
        }
    }
}

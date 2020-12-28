using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private G healthBar;
    private void Start()
    {
        healthBar.SetSize(.4f);
    }

}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

[RequireComponent(typeof(Random))]

public class CharacterSwitch : MonoBehaviour
{
    public float Points = 15f;
    public bool gift;
    private GameObject Player;
    enum Enmuerator
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Points++;
        }
        else
        {
            Points--;
        }

        if (gift==true)
        {
            return;
        }
        else
        {
            Destroy(Player);
        }
    }
}

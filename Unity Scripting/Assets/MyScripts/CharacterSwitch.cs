using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSwitch : MonoBehaviour
{
    public enum Character
    {
        Girl,
        Boy,
        Nonbinary,
        dog,
        cat
    }

    public Character currentSwitch;

    public void runCurrentSwitch()
    {
        switch (currentSwitch)
        {
            case Character.Girl:
                break;
            case Character.Boy:
                break;
            case Character.Nonbinary:
                break;
            case Character.dog:
                break;
            case Character.cat:
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}

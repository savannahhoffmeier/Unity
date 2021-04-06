using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D;
using UnityEngine;
using UnityEngine.Events;

public class GameAction : ScriptableObject
{
    public UnityAction action;
    // Start is called before the first frame update
    public void Raise()
    {
        action.Invoke();
    }
}

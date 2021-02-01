using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

[RequireComponent(typeof(Rigidbody))]
public class AIHomework : MonoBehaviour
{
    public enum GameStates
    {
        Starting,
        Playing,
        Ending,
        InStore,
        Pausing
    }

    public GameStates currentGameStates = GameStates.Starting;

    public void ChangeToPlaying()
    {
        currentGameStates = GameStates.Playing;
    }

    public void RunCurrentState()
    {
        switch (currentGameStates)
        {
            case GameStates.Starting:
                Debug.Log("Starting");
                break;
            case GameStates.Playing:
                Debug.Log("Playing");
                break;
            case GameStates.Ending:
                Debug.Log("Playing");
                break;
            case GameStates.InStore:
                Debug.Log("InStore");
                break;
            case GameStates.Pausing:
                Debug.Log("Pausing");
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}

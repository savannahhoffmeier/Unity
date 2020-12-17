using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class G : MonoBehaviour
{
    private GameObject player;
    public enum Gamepoints
    {
        Start,
        Play,
        GameOver,
        Store,
        Pause
    }

    public Gamepoints CurrentGamepoints = Gamepoints.Start;

    public void Playing()
    {
        CurrentGamepoints = Gamepoints.Play;
    }

    public void RunCurrentState()
    {
        switch (CurrentGamepoints)
        {
            case Gamepoints.Start:
                Debug.Log("Game Start");
                break;
            case Gamepoints.Play:
                Debug.Log("Play");
                break;
            case Gamepoints.GameOver:
                Debug.Log("Game Over");
                Destroy(player);
                break;
            case Gamepoints.Store:
                Debug.Log("Storage");
                break;
            case Gamepoints.Pause:
                Debug.Log("Game Paused");
                break;
        }
    }
}

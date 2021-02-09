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
    public Text dispalyT;
    private Touch Touch;
    private float TouchEnded;
    private float Timed = .5f;

    private void Update()
    {
        if (Input.touchCount>0)
        {
            Touch = Input.GetTouch(0);
            dispalyT.text = Touch.phase.ToString();
            if (Touch.phase==TouchPhase.Ended)
            {
                TouchEnded = Time.time;
            }
        }
        else
        {
            if (Time.time-TouchEnded>Timed)
            {
                dispalyT.text = "End of Text";
            }
        }
    }
}

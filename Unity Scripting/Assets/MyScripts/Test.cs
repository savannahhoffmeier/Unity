using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Test : MonoBehaviour
{
    float speed = .5f;
    (int, int) positionToMoveTo = (3, 6);

    void Start()
    {
        Cursor.visible = false;
    }
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, positionToMoveTo, speed * Time.deltaTime);
    }
}

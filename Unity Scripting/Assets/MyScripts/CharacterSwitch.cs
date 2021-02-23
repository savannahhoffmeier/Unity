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
    public int score;
    public float health;
    public string playerName;
    public bool canPlay;
    public GameObject playerArt;
    public Transform playerTransform;

    private CharacterController _controller;
    private Vector3 movement;
    // Start is called before the first frame update
    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = 3f;
        _controller.Move(movement);
    }
}

/*
 * Kevon Long
 * Obstacles.cs
 * Assignment #11
 * handles the movement of the spikes and the objects
 */

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    private Rigidbody2D rb;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if(GameFacade.gameStatus)
        {
            rb.velocity = Vector2.left * 10.0f;
        }
    }
    

    public void MoveRight()
    {
         
    }
}

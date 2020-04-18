/*
 * Kevon Long
 * GameFacade.cs
 * Assignment #11
 * facade that holds references to the behaviours of all of the objects in the game
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameFacade : MonoBehaviour
{
    public Obstacles obstacles;
    public Player player;
    public Door door;
    public static bool gameStatus = false;

    public GameObject instructionText;

    // Start is called before the first frame update
    void Start()
    {
        gameStatus = false;
    }

    // Update is called once per frame
    void Update()
    {
        obstacles.MoveRight();
    }

    public void PlayGame()
    {
        gameStatus = true;
        door.Close();
        player.SetJump(true);
        instructionText.SetActive(false);
    }



}

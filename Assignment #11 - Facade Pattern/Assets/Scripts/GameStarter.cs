/*
 * Kevon Long
 * GameStarter.cs
 * Assignment #11
 * Client code that starts the facade
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStarter : MonoBehaviour
{

    public GameFacade gameFacade;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            gameFacade.PlayGame();
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            
            SceneManager.LoadScene("GameScene");
        }
    }
}

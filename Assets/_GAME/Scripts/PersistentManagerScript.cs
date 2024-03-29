﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentManagerScript : MonoBehaviour
{
    public static PersistentManagerScript Instance { get; private set; }
    public int points;

    public GameObject gameOverSign;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
                Destroy(gameObject); 
        }
    }
 
    public void GameOverSign()
    {
        Debug.Log("Game Over SIGN");
        gameOverSign.SetActive(true);
    }
  

}   

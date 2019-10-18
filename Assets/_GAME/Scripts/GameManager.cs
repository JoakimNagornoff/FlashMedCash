using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int startLives = 3;

    public LivesController livesController;
   // public PlayerController playerController;
    public SpawnerController spawnerController;
    public GameObject Player;

    //metod sätter liv till spelaren i början av spelet.
    private void Start()
    {
        //PlayerPrefs.SetInt("PlayerCurrentLives", startLives);
        livesController.InitLives(startLives);
       // spawnerController = GetComponent<SpawnerController>();
    }

   /* public void Startlives()
    {
        livesController.InitLives(startLives);
    }*/
   /* private void Update()
    {
        if(startLives == 0)
        {
            Player.GetComponent("PlayerController").enabled = false;
        }
    }*/


}

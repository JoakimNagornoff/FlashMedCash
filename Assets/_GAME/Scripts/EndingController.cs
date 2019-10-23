using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingController : MonoBehaviour
{
    public PlayerController playerController;
    public GameObject Winning;

    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            playerController.GameOver();
            Winning.SetActive(true);
        }
    }
    
}

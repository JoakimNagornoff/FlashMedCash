using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
    private Transform myLocation;
    public float movementSpeed = 2.0f;
    Vector3 startPos;
    int points = 0;
    bool cooldownMovment = false;
    bool cooldownMovmentStop = false;
    bool PlayerStop = false;

    float timePressed = -10;
    float slowTimePressed = -10;

    public TextMeshPro scoreText;


    private LivesController livesController;
    public SpawnerController spawnerController;

    public SpawnerController spawnerControllerLeft;
    public SpawnerController spawnerControllerRight;

    public SpawnerController spawnerController1Left;
    public SpawnerController spawnerController1Midd;
    public SpawnerController spawnerController1Right;

    public SpawnerController spawnerController2Left;
    public SpawnerController spawnerController2Midd;
    public SpawnerController spawnerController2Right;

    
    public void Start()
    {
        myLocation = this.transform;
        startPos = myLocation.position;

        livesController = GameObject.Find("lives").GetComponent<LivesController>();
    }

 
    //event klick på touch
    private void OnEnable()
    {
        InputButton.OnLeft += OnLeftPressed;
        InputButton.OnRight += OnRightPressed;
    }
    private void OnDisable()
    {
        InputButton.OnLeft -= OnLeftPressed;
        InputButton.OnRight -= OnRightPressed;
    }
    private void Update()
    {
        movementSpeed = 2;
        if (Time.time < timePressed + 0.1f)
        {
            movementSpeed = 30;
        }
        if (Time.time < slowTimePressed + 0.5f)
        {
            movementSpeed = 0;
        }
        else if (PlayerStop == false)
        {
            Vector3 pos = transform.position;
            pos.x += movementSpeed * Time.deltaTime;
            transform.position = pos;
        }
        
    }
    //metod när spelaren har sprungit klart banan, sätt en poäng.

    
    //metod när spelaren har blivit träffad.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "SHOTS")
        { 
            PlayerHited();
        }
    }
    //vänster button metod för att stanna upp.
    private void OnLeftPressed()
    {
        if(cooldownMovmentStop == false)
        {
            slowTimePressed = Time.time;
            Invoke("ResetCooldownStop", 1.2f);
            cooldownMovmentStop = true;
        }
    }
    //höger button metod för att springa snabbare.
    private void OnRightPressed()
    {
        if(cooldownMovment == false)
        {
            timePressed = Time.time;
            Invoke("ResetCooldown", 1.2f);
            cooldownMovment = true;
        }
        

    }
    private void ResetCooldown()
    {
        cooldownMovment = false;
    }
    private void ResetCooldownStop()
    {
        cooldownMovmentStop = false;
    }

    //metod om spelaren blir träffad ta bort ett liv.
    public void PlayerHited()
    {
        if(!livesController.RemoveLife())
        {
            GameOver();
          // persistentManagerScript.GameOverSign();
        }

    }
    public void GameOver()
    {
        if (spawnerController != null)
            spawnerController.Stop();
        if (spawnerControllerLeft != null)
            spawnerControllerLeft.Stop();
        if(spawnerControllerRight != null)
             spawnerControllerRight.Stop();
        if(spawnerController1Left != null)
              spawnerController1Left.Stop();
        if(spawnerController1Midd != null)
              spawnerController1Midd.Stop();
        if(spawnerController1Right != null)
              spawnerController1Right.Stop();
        if(spawnerController2Left != null)
             spawnerController2Left.Stop();
        if(spawnerController2Midd != null)
            spawnerController2Midd.Stop();
        if(spawnerController2Right != null)
            spawnerController2Right.Stop();
        playerStop();
        FindObjectOfType<PersistentManagerScript>().GameOverSign();
       // persistentManagerScript.GameOverSign();
       // Debug.Log("Game over");
    }

    public void playerStop()
    {
        PlayerStop = true;
       

    }


}

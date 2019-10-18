using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesController : MonoBehaviour
{
    public float distance = 0.8f;
    public List<GameObject> lives = new List<GameObject>();
    private int lifeCounter;

    private Transform camera;


    private void Start()
    {
        //lifeCounter = PlayerPrefs.GetInt("PlayerCurrentLives");
        DontDestroyOnLoad(gameObject);
        //    transform.parent = Camera.main.transform;
        //camera = ;

    }


    private void Update()
    {
        transform.position = Camera.main.transform.position;
    }
    public void InitLives(int count)
    {   
        //addera första livet
        GameObject firstLive = transform.GetChild(0).gameObject;
        lives.Add(firstLive);

        if(firstLive == null)
        {
            Debug.LogError(" no lives");
            return;
        }
        for(int i = 0; i < count + 0; i++)
        {
            //metod sätter 3 liv till
            GameObject live = Instantiate(firstLive);
            lives.Add(live);
            live.transform.parent = transform;
            Vector3 pos = live.transform.position;
            pos.x += distance * (i + 1);
            live.transform.position = pos;
        }
    }

    //metod tar bort liv.
    public bool RemoveLife()
    {

        if (lives.Count < 1)
        {
            return false;
        }

        GameObject lastLive = lives[lives.Count - 1];
        lives.RemoveAt(lives.Count - 1);
        lastLive.SetActive(false);

        if (lives.Count < 1)
        {
            return false;
        }
        return true;

    }


   
}

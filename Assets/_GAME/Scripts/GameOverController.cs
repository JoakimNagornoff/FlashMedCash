using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{

    public void RestartGame()
    {
        SceneManager.LoadScene("Level 1");
        FindObjectOfType<PersistentManagerScript>().gameOverSign.SetActive(false);
        //FindObjectOfType<GameManager>().Startlives();
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);


        // destroy lives
        // destroy persistantMan


        Destroy(GameObject.Find("lives"));
        Destroy(GameObject.Find("PersistentManager"));


    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("quit");
    }

}

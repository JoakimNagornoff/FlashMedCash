using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{

    public void RestartGame()
    {
        SceneManager.LoadScene("Level1");
        FindObjectOfType<PersistentManagerScript>().gameOverSign.SetActive(false);
        Destroy(GameObject.Find("lives"));
        Destroy(GameObject.Find("PersistentManager"));


    }
    public void WinnerRestartGame()
    {
        SceneManager.LoadScene("Level1");
        PersistentManagerScript.Instance.points = 0;
        Destroy(GameObject.Find("lives"));
        Destroy(GameObject.Find("PersistentManager"));

    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("quit");
    }

}

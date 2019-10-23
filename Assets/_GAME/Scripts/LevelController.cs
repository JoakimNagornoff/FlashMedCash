using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class LevelController : MonoBehaviour
{
    public int index;
    public string levelName;
    public TextMeshPro scoreText;
    //public PlayerController playerController;
    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(index);
            PersistentManagerScript.Instance.points++;
            //playerController.DoubleMovementspeed();


            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }

    }

  /*  private void Start()
    {
        scoreText.text = PersistentManagerScript.Instance.points.ToString();
    }*/
}
  

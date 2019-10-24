using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2Controller : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D end2)
    {
        SceneManager.LoadScene("Level3");
        PersistentManagerScript.Instance.points++;
    }
}

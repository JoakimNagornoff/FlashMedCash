using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointsController : MonoBehaviour
{
    private TextMeshPro scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<TextMeshPro>();
        scoreText.text =  PersistentManagerScript.Instance.points.ToString();    
    }

    
}

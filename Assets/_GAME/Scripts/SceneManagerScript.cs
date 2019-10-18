using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneManagerScript : MonoBehaviour
{
    public Text ValueText;

    private void Start()
    {
        ValueText.text = PersistentManagerScript.Instance.points.ToString();
    }
}

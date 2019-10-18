using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        DestroyShot();
    }

    void DestroyShot()
    {
        Destroy(gameObject);
    }
}

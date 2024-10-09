using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Invoke("RelodScene",2f);
        }
    }
    
    void RelodScene()
    {
        SceneManager.LoadScene(0);
    }
}

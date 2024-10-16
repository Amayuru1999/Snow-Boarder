using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float loadDelay = 0.5f;
    [SerializeField] ParticleSystem crashEffect;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground")
        {
            crashEffect.Play();
            Invoke("RelodScene",loadDelay);
        }
    }
    
    void RelodScene()
    {
        SceneManager.LoadScene(0);
    }
}

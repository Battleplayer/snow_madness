using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crash : MonoBehaviour
{
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] float crashDelay = .5f;

    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Ground") {
            crashEffect.Play();
            Invoke("ReloadScene", crashDelay);
        }
    }
}

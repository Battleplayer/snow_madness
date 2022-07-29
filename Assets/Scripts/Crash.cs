using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crash : MonoBehaviour
{
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] float crashDelay = .5f;
    [SerializeField] AudioClip crashSFX;
    bool isDamaged = false;


    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Ground" && !isDamaged) {
            isDamaged = true;
            FindObjectOfType<PlayerController>().DisableControls();
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("ReloadScene", crashDelay);
        }
    }
}

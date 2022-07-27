using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    float finishDelay = .5f;
    [SerializeField] ParticleSystem finishEffect;
    
    private void ReloadScene() 
    {
        SceneManager.LoadScene(0);
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Xander") {
            finishEffect.Play();
           Invoke("ReloadScene", finishDelay);
        }
    }
}

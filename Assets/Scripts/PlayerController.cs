using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 2f;
    [SerializeField] float boostSteed = 30f;
    [SerializeField] float baseSpeed = 20f;

    Rigidbody2D rd2d;
    SurfaceEffector2D surfaceEffector2D;
    // Start is called before the first frame update
    void Start()
    {
         rd2d = GetComponent<Rigidbody2D>();
         surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    private void RotatePlayer () 
    {
        if (Input.GetKey(KeyCode.LeftArrow)) {
            rd2d.AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow)) {
            rd2d.AddTorque(-torqueAmount);
        }
    }
    private void BoostPlayer () 
    {
        if (Input.GetKey(KeyCode.UpArrow)) {
            surfaceEffector2D.speed = boostSteed;
        } else {
            surfaceEffector2D.speed = baseSpeed;
        }
    }
    // Update is called once per frame
    void Update()
    {   
        RotatePlayer();
        BoostPlayer();
    }
}

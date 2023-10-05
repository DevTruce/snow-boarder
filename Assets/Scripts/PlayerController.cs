using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour
{

    [SerializeField] float torqueAmount = 1f;
    [SerializeField] float boostSpeed = 30f;
    [SerializeField] float baseSpeed = 20f;
    SurfaceEffector2D surfaceEffector2D;
    Rigidbody2D rb2d;


   void RotatePlayer()
    {
      if(Input.GetKey(KeyCode.LeftArrow))
       {
        rb2d.AddTorque(torqueAmount);
       }
       else if(Input.GetKey(KeyCode.RightArrow))
       {
        rb2d.AddTorque(-torqueAmount);
       }
    }

     void RespondToBoost()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
         surfaceEffector2D.speed = boostSpeed;
        } 
        else 
        {
         surfaceEffector2D.speed = baseSpeed;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
       rb2d = GetComponent<Rigidbody2D>();
       surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }


    // Update is called once per frame
    void Update()
    {
       RotatePlayer();
       RespondToBoost();
    }

}

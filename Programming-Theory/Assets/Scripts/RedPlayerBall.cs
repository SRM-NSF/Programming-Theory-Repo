using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPlayerBall : BasePlayerBall //Inheritance
{

    protected override void SetParameters()
    {
        //Polymorphism
        speed = 10;
        jumpHeight = 5;
        ballRb = GetComponent<Rigidbody>();
        mainCamera = Camera.main;
    }
    // Start is called before the first frame update
    void Awake()
    {
        SetParameters();
    }

    // Update is called once per frame
    void Update()
    {
        CameraFollow();
        Moving();

        if (Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            Jumping();
        }
    }




}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePlayerBall : BasePlayerBall //Inheritance
{
    protected override void SetParameters()
    {
        //Polymorphism
        speed = 2;
        jumpHeight = 2;
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

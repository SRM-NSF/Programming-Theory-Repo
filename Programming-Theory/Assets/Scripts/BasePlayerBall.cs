using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayerBall : MonoBehaviour
{
    public Camera mainCamera;
    public Rigidbody ballRb;
    public float speed;
    public float jumpHeight;
    protected float verticalInput;
    protected float horizontalInput;
    public bool onGround = false;

    protected void CameraFollow()
    {
        //Abstraction
        mainCamera.transform.position = new Vector3(transform.position.x, (transform.position.y + 10), (transform.position.z - 1));
    }

    protected virtual void SetParameters()
    {
        //abstraction
        speed = 0;
        jumpHeight = 0;
        ballRb = GetComponent<Rigidbody>();
        mainCamera = Camera.main;
    }

    protected void Moving()
    {
        //Abstraction
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        ballRb.AddForce(Vector3.forward * speed * verticalInput);
        ballRb.AddForce(Vector3.right * speed * horizontalInput);
    }

    protected void Jumping()
    {
        ballRb.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
        onGround = false;
    }

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

    public void OnCollisionEnter(Collision collision)
    {
        onGround = true;
    }
}

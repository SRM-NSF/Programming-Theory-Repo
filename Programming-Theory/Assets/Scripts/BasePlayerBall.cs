using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayerBall : MonoBehaviour
{
    public Camera mainCamera;
    public Rigidbody ballRb;
    public float speed;
    public float jumpHeight;
    private float verticalInput;
    private float horizontalInput;
    public bool onGround = false;

    void CameraFollow()
    {
        //Abstraction
        mainCamera.transform.position = new Vector3(transform.position.x, (transform.position.y + 10), (transform.position.z - 1));
    }

    public virtual void Moving()
    {
        //Abstraction
        speed = 0;
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        ballRb.AddForce(Vector3.forward * speed * verticalInput);
        ballRb.AddForce(Vector3.right * speed * horizontalInput);
    }
   
    void Awake()
    {
        ballRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        CameraFollow();
        Moving();

        if (Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            ballRb.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
            onGround = false;
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        onGround = true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    //SerializeField allows private variables to be seen and changed in the inspector
    [SerializeField] private float speed = 1.5f;
    [SerializeField] private float rotationSpeed = 2;

    private float maxVelocity = 3;
    
    void Start()
    {
        //Get a reference to the attached RigidBody2D component
        rb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        //Get user inputs
        float xAxis = Input.GetAxis("Horizontal");
        Rotate(xAxis * -rotationSpeed);

        if (Input.GetKey(KeyCode.Space)) {
            ThrustForward();
        }

        ClampVelocity();
    }

    //Clamp velocity according to max velocity
    private void ClampVelocity() {
        float x = Mathf.Clamp(rb.velocity.x, -maxVelocity, maxVelocity);
        float y = Mathf.Clamp(rb.velocity.y, -maxVelocity, maxVelocity);

        rb.velocity = new Vector2(x, y);
    }

    //Apply forward force
    private void ThrustForward() {
        Vector2 force = transform.up * speed;
        rb.AddForce(force);
    }

    //Rotate the object
    private void Rotate(float amount) {
        transform.Rotate(0, 0, amount);
    }
}

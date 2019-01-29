using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

    //Set a variable for the RigidBody2D component on Player
    Rigidbody2D rb;

    //Create a public variable to control the speed
    public int speed;

	// Use this for initialization
	void Start () {
        //Find and set the Rigidbody2D component to rb
        rb = GetComponent<Rigidbody2D>();
        
	}
	
	// Update is called once per frame
	void Update () {
        move();
	}

    private void move()
    {
        //Get the inputs for the arrow keys
        float hInput = Input.GetAxis("Horizontal");
        float vInput = Input.GetAxis("Vertical");

        //Normalize the vector from the inputs
        Vector2 velVector = new Vector2(hInput, vInput).normalized;

        //Add velocity(speed) to Player
        rb.velocity = velVector * speed;

    }
}

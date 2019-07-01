using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreController : MonoBehaviour {

    //Takes in the Text UI Object so that the UI element can be changed when needed
    public Text score;

    //Keeps track of the score of the player
    private int num;

	// Use this for initialization
	void Awake () {
        //Set the default score to 0
        num = 0;

        //Give the Text UI element a default string to start off with
        if (score != null)
        {
            score.text = "Score: " + num.ToString();
        }
	}

    //A function that will add 1 to the score whenever it is called
    void addScore()
    {
        num += 1;
        if (score != null)
        {
            score.text = "Score: " + num.ToString();
        }
    }

    //OnCollision functions will occur when something collides with something else. 
    //You can check what the object collided with before doing something with it
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Checks if the item that the player collided with is of the tag "Collectible", 
        //which lets the script know that it should collect it and increase the score
        if (collision.gameObject.tag.Equals("Collectable"))
        {
            addScore();

            //Destroy will remove the gameobject from the current game
            Destroy(collision.gameObject);
        }
    }
}

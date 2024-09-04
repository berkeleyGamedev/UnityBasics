using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.CompareTag("Asteroid")) {
            Collide(collision.gameObject);
        }
    }

    private void Collide(GameObject asteroid) {
        GameObject.FindGameObjectWithTag("UI").GetComponent<UIScript>().IncreaseScore();
        Destroy(asteroid);
        Destroy(gameObject);
    }
}

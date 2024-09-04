using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public Text scoreText;
    public Text healthText;

    public Text gameOverText;
    private bool gameOver;

    [SerializeField] private int scoreToWin;
    private int score = 0;

    private PlayerHealth player;

    private void Start() {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();

        UpdateUI();
    }

    private void Update() {
        UpdateUI();
    }

    private void UpdateUI() {
        if (gameOver) {
            return;
        }

        scoreText.text = "Score: " + score;
        healthText.text = "Health: " + player.currentHealth;

        if (player.currentHealth <= 0) {
            gameOver = true;
            gameOverText.text = "You lost!";
        }
    }

    public void IncreaseScore() {
        score++;

        if (score >= scoreToWin && !gameOver) {
            gameOver = true;
            gameOverText.text = "You won!";
        }
    }

}

﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour {

    public static GameControl instance;
    public Text scoreText;
    public Text restartText;
    public GameObject gameOverText;
    public bool gameOver = false;
    public float scrollSpeed = -1.5f;

    private int score = 0;

    void Awake () {
        if (instance == null) {
            instance = this;
        }
        else if (instance != this) {
            Destroy(gameObject);
        }
    }
	
	void Update () {
	    if (gameOver && Input.GetMouseButtonDown(0)) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
	}

    public void BirdScored() {
        if (gameOver)
            return;

        score++;
        scoreText.text = "Score: " + score.ToString();
       
    }


    public void BirdDied () {
        gameOverText.SetActive (true);
        gameOver = true;
    }
}
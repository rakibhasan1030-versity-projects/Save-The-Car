using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnemyDestroyer : MonoBehaviour {
    public Text scoreText;
    public Text highScoreText;
    int score = 0, highScore = 0;
    public uiManager ui;

    void Start () {
        score = 0;
        highScore = 0;
    }

   public void Update () {
       
        scoreText.text = "Score: " + score;
        if (score >= highScore)
       {
            highScore = score;
       }
    }

    public void HighScore()
    {
        highScoreText.gameObject.SetActive(true);
        highScoreText.text = "High Score : " + highScore;
        highScoreText.gameObject.SetActive(true);
    }

    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "Enemy Car")
        {
            Destroy(col.gameObject);
            score ++;
        }

    }

    
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUp : MonoBehaviour
{

    public Text scoreText;
    public Text highScoreText;
    private int scoreNumber;
    private int highScore;

    private void Start()
    {
        highScore = PlayerPrefs.GetInt("highscore");
        highScoreText.text = highScore.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        scoreNumber++;
        scoreText.text = scoreNumber.ToString();
        if (scoreNumber > highScore)
        {
            highScore = scoreNumber;
            PlayerPrefs.SetInt("highscore", highScore);
            highScoreText.text = highScore.ToString();
        }
    }
}


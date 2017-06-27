using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomepageHighScoreScript : MonoBehaviour {

    //This script is just here to put the player's high score on the main menu.
    private int highScore;
    public Text highScoreDisplay;

	void Start () {

        //Get the highscore from the player prefs.
        highScore = PlayerPrefs.GetInt("highscore");
        highScoreDisplay.text = highScore.ToString();

	}
	

}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameScore : MonoBehaviour {

    public Text totalScoreText;
    public Text gameOverText;

    private int totalScore;
    private int totalInvalidShots;
    //Final screen, gives info on how well you did
	void Start() 
    {
        totalScoreText.text = "";
        totalInvalidShots = PlayerPrefs.GetInt("Invalid Shots");
        totalScore = PlayerPrefs.GetInt("Player Score");
        print(totalInvalidShots);
        if(totalInvalidShots<5)
        {
            gameOverText.text = "Congratulations!";
            totalScoreText.text = "Your total score: " + totalScore;
            if(totalScore<500)
            {
                totalScoreText.text += "\n Only " + (500 - totalScore) + " from the bonuslevel!";
            }
            
        }
        //If you get 5 invalid shots you lose
        else
        {
            gameOverText.text = "Game Over";
        }
	}
}

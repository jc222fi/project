using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameScore : MonoBehaviour {

    public Text totalScoreText;
    public Text gameOverText;

    private int totalScore;
    private int totalInvalidShots;
	// Use this for initialization
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
            
        }
        else
        {
            gameOverText.text = "Game Over";
        }
        
        //UpdateScore();
	}
    //void UpdateScore()
    //{
    //    // + PlayerPrefs.GetInt("Player Score");
    //}
}

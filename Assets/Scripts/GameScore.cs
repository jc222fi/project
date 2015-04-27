using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameScore : MonoBehaviour {

    public Text totalScoreText;

    private int totalScore;
	// Use this for initialization
	void Start() 
    {
        totalScore = PlayerPrefs.GetInt("Player Score");
        totalScoreText.text = "Total score: " + totalScore;
        //UpdateScore();
	}
    //void UpdateScore()
    //{
    //    // + PlayerPrefs.GetInt("Player Score");
    //}
}

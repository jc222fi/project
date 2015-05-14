using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BonusController : MonoBehaviour 
{
    public Text scoreText;

    private int score;
    // Use this for initialization
	void Start() 
    {
        score = PlayerPrefs.GetInt("Player Score");
        scoreText.text = "Score: " + score;
	}
	
	// Update is called once per frame
	void Update() 
    {
	
	}
}

using UnityEngine;
using System.Collections;

public class NewGame : MonoBehaviour {
    //Reset game if player wants to play again
	public void ButtonClickedEvent()
    {
        PlayerPrefs.SetInt("Player Score", 0);
        PlayerPrefs.SetInt("Invalid Shots", 0);
        Application.LoadLevel("GooseChase");
    }
}

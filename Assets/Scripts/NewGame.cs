using UnityEngine;
using System.Collections;

public class NewGame : MonoBehaviour {

	public void ButtonClickedEvent()
    {
        PlayerPrefs.SetInt("Player Score", 0);
        Application.LoadLevel("GooseChase");
    }
}

using UnityEngine;
using System.Collections;

public class NewGame : MonoBehaviour {

	public void ButtonClickedEvent()
    {
        print("Clicked");
        Application.LoadLevel("GooseChase");
    }
}

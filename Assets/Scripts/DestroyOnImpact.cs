using UnityEngine;
using System.Collections;

public class DestroyOnImpact : MonoBehaviour {
    public int scoreValue;

    private GameController gameController;

    void Start()
    {
        GameObject gameObject = GameObject.FindGameObjectWithTag("GameController");

        if(gameObject != null)
        {
            gameController = gameObject.GetComponent<GameController>();
        }
    }
	void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        Destroy(gameObject);
        gameController.AddScore(scoreValue);
    }
}

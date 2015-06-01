using UnityEngine;
using System.Collections;

public class Misses : MonoBehaviour {
    //This script records your misses and sends info to game controller
    public int scoreValue;

    private int invalidShot = 1;
    private GameController gameController;
	void Start () 
    {
        GameObject gameObject = GameObject.FindGameObjectWithTag("GameController");

        if (gameObject != null)
        {
            gameController = gameObject.GetComponent<GameController>();
        }
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy")||other.gameObject.CompareTag("Enemy2"))
        {
            gameController.AddScore(scoreValue);
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(other.gameObject);
            gameController.AddMiss(invalidShot);
        }
    }
}

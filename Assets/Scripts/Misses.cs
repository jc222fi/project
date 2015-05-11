using UnityEngine;
using System.Collections;

public class Misses : MonoBehaviour {

    public int scoreValue;

    private int invalidShot = 1;
    private GameController gameController;
	// Use this for initialization
	void Start () 
    {
        GameObject gameObject = GameObject.FindGameObjectWithTag("GameController");

        if (gameObject != null)
        {
            gameController = gameObject.GetComponent<GameController>();
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        if (other.gameObject.CompareTag("Enemy")||other.gameObject.CompareTag("Enemy2"))
        {
            gameController.AddScore(scoreValue); 
        }
        else //if (other.gameObject.CompareTag("Player"))
        {
            gameController.AddMiss(invalidShot);
        }
    }
}

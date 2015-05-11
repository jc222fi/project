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
        if ((gameObject.CompareTag("Enemy") || gameObject.CompareTag("Enemy2")) && other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            gameController.AddScore(scoreValue);
        }
    }
}

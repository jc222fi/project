using UnityEngine;
using System.Collections;

public class DestroyOnImpact : MonoBehaviour {

    public int scoreValue;

    private GameController gameController;
    private BonusController bonusController;
    private AudioSource audio;
    void Start()
    {
        GameObject gameObject = GameObject.FindGameObjectWithTag("GameController");
        GameObject gameObject2 = GameObject.FindGameObjectWithTag("Bonus Controller");
        audio = GetComponent<AudioSource>();

        if(gameObject != null)
        {
            gameController = gameObject.GetComponent<GameController>();
        }
        else
        {
            bonusController = gameObject2.GetComponent<BonusController>();
        }
    }
    //Method to specify events depending on level and what object is hit
	void OnTriggerEnter2D(Collider2D other)
    {
        //If one object is the enemy and the other is the bullet, add score and destroy both objects
        if ((gameObject.CompareTag("Enemy") || gameObject.CompareTag("Enemy2")) && other.gameObject.CompareTag("Bullet"))
        {
            print(audio);
            Destroy(other.gameObject);
            Destroy(gameObject);
            if (Application.loadedLevel==1)
            {
                gameController.AddScore(scoreValue);
                audio.Play();
            }
            else
            {
                bonusController.AddScore(scoreValue);
            }
        }
    }
}

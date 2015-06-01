using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    
    public GameObject enemyPrefab;
    public GameObject enemyPrefab2;
    public Transform enemySpawn;
    public Text scoreText;
    public Text commentText;
    public Text numberOfInvalidShots;
    public Vector2 spawnValues;

    private float spawnWait;
    private int score;
    private int invalidShots;
    private string[] comments = new string[] { "No birds there", "Are you stupid?", "Sucker", "You're gonna lose", "LOSER" };
    void Start()
    {
        //At the start of the game, start spawning enemies
        StartCoroutine(EnemySpawn());
        StartCoroutine(EnemySpawn2());
        score = 0;
        UpdateScore();
    }
    //Update score and misses, depending on if the enemy is hit by a bullet or makes it across the field unharmed
    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
        PlayerPrefs.SetInt("Player Score", score);
    }
    public void AddMiss(int newInvalidShot)
    {
        invalidShots += newInvalidShot;
        StartCoroutine(UpdateMiss());
        PlayerPrefs.SetInt("Invalid Shots", invalidShots);
    }
    void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }
    IEnumerator UpdateMiss()
    {
        commentText.text = comments[invalidShots - 1];
        numberOfInvalidShots.text = "Invalid Shots: " + invalidShots;
        yield return new WaitForSeconds(2);
        commentText.text = "";
        //If you shoot too far to the right or the bottom 5 times, game over
        if (invalidShots == 5)
        {
            Application.LoadLevel("gameover");
        }
    }
    //Two spawnmethods so they will act independently spawning the clones
    IEnumerator EnemySpawn()
    {
        while (true)
        {
            Vector2 spawnPosition = new Vector2(spawnValues.x, Random.Range(-spawnValues.y, spawnValues.y));
            Instantiate(enemyPrefab, spawnPosition, enemySpawn.rotation);
            spawnWait = Random.Range(2, 7);
            yield return new WaitForSeconds(spawnWait);
        }
    }
    IEnumerator EnemySpawn2()
    {
        while (true)
        {
            Vector2 spawnPosition = new Vector2(spawnValues.x, Random.Range(-spawnValues.y, spawnValues.y));
            Instantiate(enemyPrefab2, spawnPosition, enemySpawn.rotation);
            spawnWait = Random.Range(1, 5);
            yield return new WaitForSeconds(spawnWait);
        }
    }
}

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
    // Use this for initialization
    void Start()
    {
        StartCoroutine(GameTimer());
        StartCoroutine(EnemySpawn());
        StartCoroutine(EnemySpawn2());
        score = 0;
        UpdateScore();
    }
    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }
    public void AddMiss(int newInvalidShot)
    {
        invalidShots += newInvalidShot;
        StartCoroutine(UpdateMiss());
        if (invalidShots==5)
        {
            PlayerPrefs.SetInt("Invalid Shots", invalidShots);
            Application.LoadLevel("gameover");
        }
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
    }
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
    IEnumerator GameTimer()
    {
        yield return new WaitForSeconds(30);
        PlayerPrefs.SetInt("Player Score", score);
        PlayerPrefs.SetInt("Invalid Shots", invalidShots);
        Application.LoadLevel("gameover");
    }
}

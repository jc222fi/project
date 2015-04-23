using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    
    public GameObject enemyPrefab;
    public Transform enemySpawn;
    public Text scoreText;
    public Vector2 spawnValues;
    public int enemyCount;

    private int score;
    // Use this for initialization
    void Start()
    {
        EnemySpawn();
        score = 0;
        UpdateScore();
    }
    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }
    void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }
    void EnemySpawn()
    {
        for (int i = 0; i < enemyCount; i++)
        {
            Vector2 spawnPosition = new Vector2(spawnValues.x, Random.Range(-spawnValues.y, spawnValues.y));
            Instantiate(enemyPrefab, spawnPosition, enemySpawn.rotation); 
        }
    }
}

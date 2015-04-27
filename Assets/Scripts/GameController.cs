using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    
    public GameObject enemyPrefab;
    public Transform enemySpawn;
    public Text scoreText;
    public Vector2 spawnValues;
    public int enemyCount;
    public float spawnWait;

    private int score;
    // Use this for initialization
    void Start()
    {
        print(GameTimer());
        StartCoroutine(GameTimer());
        StartCoroutine(EnemySpawn());
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
    IEnumerator EnemySpawn()
    {
        while (true)
        {
            Vector2 spawnPosition = new Vector2(spawnValues.x, Random.Range(-spawnValues.y, spawnValues.y));
            Instantiate(enemyPrefab, spawnPosition, enemySpawn.rotation);
            yield return new WaitForSeconds(spawnWait);
        }
    }
    IEnumerator GameTimer()
    {
        yield return new WaitForSeconds(300);
        Application.LoadLevel("gameover");
    }
}

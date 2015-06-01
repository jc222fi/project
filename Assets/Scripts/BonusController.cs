using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BonusController : MonoBehaviour 
{
    public Text scoreText;
    public GameObject enemyPrefab;
    public Transform enemySpawnRight;

    private float spawnWait;
    private int score;
    //On the bonus level ther are no misses, and it's unfinished with only basic controls implemented
	void Start() 
    {
        score = PlayerPrefs.GetInt("Player Score");
        scoreText.text = "Score: " + score;
        StartCoroutine(EnemySpawnRight());
	}
    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
        PlayerPrefs.SetInt("Player Score", score);
    }
    void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }
    IEnumerator EnemySpawnRight()
    {
        while (true)
        {
            Vector2 spawnPosition = new Vector2(10, -3.14f);
            Instantiate(enemyPrefab, spawnPosition, enemySpawnRight.rotation);
            spawnWait = Random.Range(1, 4);
            yield return new WaitForSeconds(spawnWait);
        }
    }
}

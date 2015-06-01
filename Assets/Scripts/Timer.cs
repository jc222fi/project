using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text gameTimer;

    private float timeLeft;
    private int score;
    //Start timer
    void Start()
    {
        timeLeft = 120f;
        StartCoroutine(GameTimer());
    }
    void Update()
    {
        //Ugly, non-optimized timer presentation code...to be improved
        timeLeft -= Time.deltaTime;
        if (timeLeft >= 120)
        {
            gameTimer.text = "2:";
            if ((timeLeft - 120) < 10)
            {
                gameTimer.text += "0" + ((int)timeLeft - 120);
            }
            else
            {
                gameTimer.text += (int)timeLeft - 120;
            }
        }
        else if (timeLeft >= 60)
        {
            gameTimer.text = "1:";
            if ((timeLeft - 60) < 10)
            {
                gameTimer.text += "0" + ((int)timeLeft - 60);
            }
            else
            {
                gameTimer.text += (int)timeLeft - 60;
            }
        }
        else
        {
            gameTimer.text = "0:";
            if (timeLeft < 10)
            {
                gameTimer.text += "0" + (int)timeLeft;
            }
            else
            {
                gameTimer.text += (int)timeLeft;
            }
        }

    }
    //Define timer settings
    IEnumerator GameTimer()
    {
        yield return new WaitForSeconds(120);
        score = PlayerPrefs.GetInt("Player Score");
        //Bonus level is only supposed to load if you're not already on the bonus level
        if (Application.loadedLevel == 1)
        {
            if (score > 500)
            {
                Application.LoadLevel("Bonus");
            }
            else
            {
                Application.LoadLevel("gameover");
            }
        }
        else
        {
            Application.LoadLevel("gameover");
        }
    }
}

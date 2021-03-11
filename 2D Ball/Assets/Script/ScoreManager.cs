using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    public static int score;
    public Text scoreText;
    public Text highScoreText;

    private void Start()
    {
        highScoreText.text = PlayerPrefs.GetInt("highScore", 0).ToString();
        score = 0;
    }

    private void Update()
    {
        scoreText.text = score.ToString();
       
        if (score > PlayerPrefs.GetInt("highScore", 0))
        {
            PlayerPrefs.SetInt("highScore", score);
        }
    }


}

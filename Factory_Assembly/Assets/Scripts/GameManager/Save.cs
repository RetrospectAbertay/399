using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Save : MonoBehaviour {
    int totalScore;

        Text totalScoreText;
        // Use this for initialization
        void Start()
        {
            //totalScore += Score.score;
            totalScoreText = GetComponent<Text>();
        }

    public void loadHighScore()
    {
        SaveHighScore();
        PlayerPrefs.GetInt("Highscore");
    }

    // Update is called once per frame
    void Update () {
        totalScoreText.text = "Total Spectrums Assembled: " + Score.score;
        totalScoreText.text = "Total Spectrums Assembled: " + 0;
    }

    public void SaveHighScore()
    {
        Debug.Log(totalScore + " total score, " + Score.score + " game score");
        PlayerPrefs.SetInt("Highscore", totalScore+Score.score);
    }



}

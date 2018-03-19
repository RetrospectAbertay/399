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
	
	// Update is called once per frame
	void Update () {
        totalScoreText.text = "Spectrum Built: " + Score.score;
    }

    public void SaveHighScore()
    {
        //PlayerPrefs.SetInt("Highscore", totalScore+Score.score);
    }

    public void loadHighScore()
    {
        SaveHighScore();
        //PlayerPrefs.GetInt("Highscore");
    }


}

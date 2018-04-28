using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManagerScript : MonoBehaviour
{
    static int totalScore;
    Score score;
    public GameObject scoreObject;

	// Use this for initialization
	void Start ()
    {
        Debug.Log("Total Score: " + totalScore);
        //DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void loadHighScore()
    {
        PlayerPrefs.GetInt("Highscore");
    }

    public void SaveHighScore()
    {
        score = scoreObject.GetComponent<Score>();

        Debug.Log(score + " total score, " + score.getScore() + " game score");
        PlayerPrefs.SetInt("Highscore", totalScore + score.getScore());
    }

    public int getScore()
    {
        Debug.Log(score + " total score, " + score.getScore() + " game score");
        loadHighScore();
        return totalScore;
    }

}

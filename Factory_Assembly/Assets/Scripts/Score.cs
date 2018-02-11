using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    // Users score
    public static int score;

    //static int totalScore;

    Text scoreText;
	// Use this for initialization
	void Start () {
        score = 0;
        scoreText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "Score: " + score;
	}
}

using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    // Users score
    public static int score;
    public SpriteRenderer scoreScreen1;
    public SpriteRenderer scoreScreen2;
    public SpriteRenderer scoreScreen3;
    public Text screen1;
    public Text screen2;
    public Text screen3;

    //static int totalScore;

    Text scoreText;
    // Use this for initialization
    void Start() {
        score = 0;
        scoreText = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update() {
        scoreText.text = "" + score;
    }

    public int getScore()
    {
        return score;
    }

    public void scoreDisplay()
    {

        screen1.text = "" + score;
        screen2.text = "" + score;
        screen3.text = "" + score;
        scoreScreen1.enabled = true;
        scoreScreen2.enabled = true;
        scoreScreen3.enabled = true;
        screen1.enabled = true;
        screen2.enabled = true;
        screen3.enabled = true;


    }
}

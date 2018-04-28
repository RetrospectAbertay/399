using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loadScore : MonoBehaviour {

    public GameObject gameManager;
    GameManagerScript gameManagerScript;
    public Text scoreText;
    int score;

	// Use this for initialization
	void Start ()
    {
        
       
	}
	
	// Update is called once per frame
	void Update ()
    {
        gameManagerScript = gameManager.GetComponent<GameManagerScript>();
        score = gameManagerScript.getScore();
        scoreText.text = "Total Spectrums Assembled: " + gameManagerScript.getScore();
    }
}

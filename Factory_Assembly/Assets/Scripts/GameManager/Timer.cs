using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    public Text timerText;
    private  float startTime;
    float t;
    private bool end = false;
    public bool correct;
    public bool incorrect;
    Score score;
    GameObject scoreGameObject;
    //public GameObject scoreSreen1;
    //public GameObject scoreSreen2;
    //public GameObject scoreSreen3;
    //public Text screen1;
    //public Text screen2;
    //public Text screen3;


    GameManagerScript gameManagerScript;
    public GameObject gameManager;

    // Use this for initialization
    void Start()
    {
        scoreGameObject = GameObject.Find("Score");
        score = scoreGameObject.GetComponent<Score>();
        Time.timeScale = 1;
        startTime = 120.0f;//Time.time;
        t = startTime;
        //scoreSreen1.SetActive(false);
        //scoreSreen2.SetActive(false);
        //scoreSreen3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (end)
        {
            gameManagerScript = gameManager.GetComponent<GameManagerScript>();
            gameManagerScript.SaveHighScore();
            SceneManager.LoadScene("StartMenu");
            return;
        }

         t -= Time.deltaTime;
        
        string seconds = (t % 120).ToString("f0");
        
        timerText.text = "Time :" + seconds;

        if (t <= 10)
        {

            timerText.color = Color.red;
            if (t <= 0)
            {
                // t = startTime;
                // 
                //end = true;
                 score.scoreDisplay();

                //Time.timeScale = 1f;
                
                if ( t <= -1 )
                {
                    Debug.Log("Scene Change" + t);
                    SceneManager.LoadScene("StartMenu");
                }
            }
        }
        if(t <= 0)
        {
           // t = startTime;
           // SceneManager.LoadScene("StartMenu");
            //StartCoroutine(scoreDisplay());
           // Debug.Log("Scene Change" + t);
            
        }
    }

    public float GetTime()
    {
        return t;
    }

    //IEnumerator scoreDisplay()
    //{
    //    Score score;
    //    int scorestring = score.getScore();
    //    screen1.text = scorestring.ToString("f0");
    //    screen2.text = scorestring.ToString("f0");
    //    screen3.text = scorestring.ToString("f0");
    //    Debug.Log( screen1.text);
    //    scoreSreen1.SetActive(true);
    //    scoreSreen2.SetActive(true);
    //    scoreSreen3.SetActive(true);
    //     yield return new WaitForSecondsRealtime(5);
    //    
    //}
}

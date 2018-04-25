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
	public AudioSource audio;
    // Use this for initialization
    void Start()
    {
        startTime = 90.0f;//Time.time;
        t = startTime;
		audio.Play ();
    }

    // Update is called once per frame
	void Update()
    {

        if (end)
        {
			
			SceneManager.LoadScene("StartMenu");
			return;
			
           
        }

         t -= Time.deltaTime;
        
        string seconds = (t % 60).ToString("f0");
        
        timerText.text = "Time :" + seconds;

        //Add five seconds to time if specrtum completed correctly

        if (correct)
        {
            t += 5.0f;
        }

        //Take seconds off the time if spectrum completed incorrectly

        if (incorrect)
        {
            t -= 2.0f;
        }

        if (t <= 10)
        {

            timerText.color = Color.red;
            if (t <= 0)
            {
               // t = startTime;
               // Debug.Log("Scene Change" + t);
                //end = true;
            }
        }
        if(t <= 0)
		{
			audio.Play ();
            t = startTime;

            Debug.Log("Scene Change" + t);
            SceneManager.LoadScene("StartMenu");
        }
 
	}



}
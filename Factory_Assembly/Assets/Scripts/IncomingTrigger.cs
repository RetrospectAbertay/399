using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class IncomingTrigger : MonoBehaviour {

    public GameObject TextObj;
    private Text Warning;
    float timer = 3;
    bool display = true;
    bool isBlinking = true;
    string blankText = " ";
    string flashingText = "Incoming!";
	// Use this for initialization
	void Start () {
        Warning = TextObj.GetComponent<Text>();
        //Warning.text = blankText;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("bottom")|| coll.gameObject.CompareTag("Keyboard"))
        {
            Debug.Log("TRIGGERED");
            StartCoroutine(BlinkText());
        }
    }
    //function to blink the text 
    public IEnumerator BlinkText()
    {
        //blink it forever. You can set a terminating condition depending upon your requirement. Here you can just set the isBlinking flag to false whenever you want the blinking to be stopped.
        while (isBlinking)
        {
            //display “I AM FLASHING TEXT” for the next 0.5 seconds
            Warning.text = flashingText;
            yield return new WaitForSeconds(.5f);
            //set the Text's text to blank
            Warning.text = "";
            //display blank text for 0.5 seconds
            yield return new WaitForSeconds(.5f);
            timer = timer - 1;
            if (timer <=0)
            {
                isBlinking = false;
            }
        }
    }
}

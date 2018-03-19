using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteScript : MonoBehaviour {
    public bool scorePoint;
    public int scoreValue;
 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D other)
    {
        /*for (int i = 0; i < partGo.Length; i++)
        {
            Debug.Log("Triggered!");
            DestroyImmediate(partGo[i].gameObject, true);
        }*/
        if(other.gameObject.tag == "stop")
        {
            //Debug.Log("Triggered!");
            Destroy(this.gameObject, 5);
            if(scorePoint == true)
            {
                Score.score += scoreValue;
            }
        }
       
    }

}

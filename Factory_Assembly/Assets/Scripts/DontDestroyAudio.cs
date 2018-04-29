using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyAudio : MonoBehaviour {

    public AudioSource ambient;

	// Use this for initialization
	void Awake () {
		GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");
		if (objs.Length > 1) 
		{
			Destroy(this.gameObject);
		}
		DontDestroyOnLoad(ambient);


    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

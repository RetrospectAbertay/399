using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyAudio : MonoBehaviour {

    public AudioSource ambient;

	// Use this for initialization
	void Awake () {
        DontDestroyOnLoad(ambient);
        ambient.Play();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

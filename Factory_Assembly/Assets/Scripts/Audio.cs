using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour {
	public string input;
	public AudioSource source;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
		if (other.CompareTag (input)) 
		{
			source.Play();
		}

    }
}

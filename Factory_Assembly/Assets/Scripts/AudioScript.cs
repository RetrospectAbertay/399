using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour {

	public AudioSource componentAddition;
	public AudioSource completedSpecrtum;
	public string input;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnTriggerExit2D(Collider2D other)
	{
		if (other.CompareTag (input)) 
		{
			componentAddition.Play();

		}
	}
}

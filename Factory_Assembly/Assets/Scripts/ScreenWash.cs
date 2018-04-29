using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenWash : MonoBehaviour {
	public Rigidbody2D gradientObject;
	public bool gradientMove = false;
	public float _GradientForce = 60.0f;
	Timer time;
	GameObject timeGameObject;

	// Use this for initialization
	void Start () {
		timeGameObject = GameObject.Find("Time");
		time = timeGameObject.GetComponent<Timer>();
		if (time.GetTime() < 0) 
		{
			gradientMove = true;
		}
		
	}
	
	// Update is called once per frame
	void GradientMove () {

	}
}

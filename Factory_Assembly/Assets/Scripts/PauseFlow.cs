using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseFlow : MonoBehaviour {
	public Rigidbody2D part;
	private bool paused;
	private float _beltForceY;
	private float _beltForceX;
	public float _beltForce;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown ("a"))
		{
			if (paused == true)
			{
				paused = false;
			}
			else
			{
				paused = true;
			}

		}

		if (paused == false) 
		{
			_beltForceY += _beltForce;
			_beltForceX = 0;
		} 
		else 
		{
			part.velocity = Vector2.zero;
		}



	}
}

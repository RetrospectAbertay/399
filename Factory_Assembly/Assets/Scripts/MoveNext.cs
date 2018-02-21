using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNext : MonoBehaviour {
   	float _beltForceX;
    float _beltForceY;
    public float _beltForce;
    public Rigidbody2D parts;
	//bool pressed = false;

    // Use this for initialization
    void Start () {
       

		_beltForceX += _beltForce;
		_beltForceY = 0;
    }
	
	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown ("z")) 
		{
			//pressed = true;
			Debug.Log ("z is pressed");
			parts.velocity = new Vector2 (parts.position.x + _beltForceX, parts.position.y + _beltForceY) * Time.fixedDeltaTime;
			Debug.Log (parts.velocity);

		}
	}

}

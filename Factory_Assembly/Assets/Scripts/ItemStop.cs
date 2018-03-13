using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemStop : MonoBehaviour {
     public Rigidbody2D part;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


	}

    void OnCollisionStay2D(Collision2D other)
    {
        if (other.rigidbody == part)
        {
           // Debug.Log("Contact");
            part.velocity = Vector2.zero;
        }
    }


}

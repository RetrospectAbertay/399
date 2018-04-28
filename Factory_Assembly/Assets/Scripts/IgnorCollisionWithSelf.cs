using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnorCollisionWithSelf : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void OnCollisionEnter(Collision  other)
    {

        if (other.gameObject.tag == this.gameObject.tag)
        {
            //Physics2D.IgnoreCollision(other.gameObject, this.collider);
        }
    }

        // Update is called once per frame
        void Update () {
		
	}
}

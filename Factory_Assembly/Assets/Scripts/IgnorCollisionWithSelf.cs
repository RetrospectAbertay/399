using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnorCollisionWithSelf : MonoBehaviour {

    public GameObject gameObject;

	// Use this for initialization
	void Start () {
		
	}

    void OnCollisionEnter(Collision  other)
    {

        if (other.gameObject == gameObject)
        {
            Physics2D.IgnoreCollision(other.gameObject.GetComponent<Collider2D>(), this.gameObject.GetComponent<Collider2D>());
        }
    }

        // Update is called once per frame
        void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBottom : MonoBehaviour {

	public Rigidbody2D part;
	private bool frozen;

	public float _beltForce;
	// Use this for initialization
	void Start () {

		part = GetComponent<Rigidbody2D>();
		frozen = false;

		///part.constraints = RigidbodyConstraints2D.FreezeRotation;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D(Collider2D coll)
	{
		if (coll.gameObject.CompareTag ("stop")) {

			Debug.Log ("two");
			if (frozen == false) {
				part.constraints = RigidbodyConstraints2D.FreezePosition|RigidbodyConstraints2D.FreezeRotation;

				//part.constraints = RigidbodyConstraints2D.FreezeRotation;
				frozen = true;
			}
			//part.constraints = RigidbodyConstraints2D.None;
			if (Input.GetKeyDown ("z")) 
			{
				part.constraints = RigidbodyConstraints2D.None|RigidbodyConstraints2D.FreezePositionY;
				//part.constraints = RigidbodyConstraints2D.FreezeRotation|RigidbodyConstraints2D.FreezePositionY;
				//part.constraints = RigidbodyConstraints2D.FreezePositionY;
				part.velocity = new Vector2(part.velocity.x +_beltForce, part.velocity.y -_beltForce) * Time.fixedDeltaTime;
			}
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTop : MonoBehaviour {

	public Rigidbody2D part;
	bool down ;
	// Use this for initialization
	void Start () {
		down = false;
		part = GetComponent<Rigidbody2D>();

		part.constraints = RigidbodyConstraints2D.FreezePositionY;
		//part.constraints = RigidbodyConstraints2D.FreezeRotation;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerStay2D(Collider2D coll)
	{
		//Debug.Log("triggers");
		/*for (int i = 0; i < partGo.Length; i++)
        {
            Debug.Log("Triggered!");
            DestroyImmediate(partGo[i].gameObject, true);
        }*/
		if (down == false)
		{
			if (coll.gameObject.CompareTag ("Finish") && Input.GetKeyDown ("space")) {
				Debug.Log ("one");
				part.constraints = RigidbodyConstraints2D.FreezePositionX;

				//part.constraints = RigidbodyConstraints2D.FreezeRotation;
				down = true;

			}
		}
	}
}
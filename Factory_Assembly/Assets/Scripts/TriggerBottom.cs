using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBottom : MonoBehaviour {

	public Rigidbody2D part;
	private bool frozen;
    bool canMove;

    public string inputKey;
    public float _beltForce;
	// Use this for initialization
	void Start ()
    {

		part = GetComponent<Rigidbody2D>();
		frozen = false;
        canMove = false;
        //this.GetComponent<SpriteChange>();
        
		//part.constraints = RigidbodyConstraints2D.FreezeRotation;
	}
	
	// Update is called once per frame
	void Update ()
    {
        canMove = this.GetComponent<SpriteChange>().getBool();
        if (canMove == true)
        {
           // Debug.Log("Can Move 2");
        }
    }

	void OnTriggerStay2D(Collider2D coll)
	{
		if (coll.gameObject.CompareTag ("stop")) {

			//Debug.Log ("two");
			if (frozen == false) {
				part.constraints = RigidbodyConstraints2D.FreezePosition | RigidbodyConstraints2D.FreezeRotation;

				//part.constraints = RigidbodyConstraints2D.FreezeRotation;
				frozen = true;
			}
            //part.constraints = RigidbodyConstraints2D.None;
            if (Input.GetKeyDown(inputKey) && canMove == true)
            {
                part.constraints = RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;
                //part.velocity = new Vector2(part.velocity.x +_beltForce, part.velocity.y -_beltForce) * Time.fixedDeltaTime;
                part.transform.Translate(new Vector3(_beltForce, 0, 0) * Time.fixedDeltaTime);
            }
		}
	}
}

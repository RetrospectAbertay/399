using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMovement : MonoBehaviour {

    // conveyer belt variables
   // float _beltForceX;
   // float _beltForceY;
    public float _beltForce;
    public Rigidbody2D parts;
	//state currentState;
   // public bool isDown;

    void Start()
    {
        parts = GetComponent<Rigidbody2D>();
        parts.constraints = RigidbodyConstraints2D.FreezePositionY;
        //     if (isDown == true)
        //     {
        //         _beltForceY += _beltForce;
        //         _beltForceX = 0;
        ////currentState = state.go;
        //     }
        //     else
        //     {
        //         _beltForceX += _beltForce;
        //         _beltForceY = 0;
        ////currentState = state.go;
        //     }

    }

  


    void Update()
    {
        //parts.MovePosition(new Vector2(parts.position.x + _beltForceX, parts.position.y + _beltForceY) * Time.fixedDeltaTime);
        //parts.velocity = new Vector2(parts.position.x + _beltForce, 0) * Time.fixedDeltaTime;
        parts.velocity = new Vector2(parts.velocity.x +_beltForce, 0) * Time.fixedDeltaTime;
       
       // if (Input.GetKeyDown("space"))
       // {
		//	Debug.Log ("Inside to stop velocity");
		//	parts.velocity = Vector2.zero;
			//_beltForceX = 0;
		//	_beltForce = 0;
		//	_beltForceY += _beltForce;
		//	_beltForceY = 0;
		//	_beltForceX += _beltForce;

        //}
   }
}

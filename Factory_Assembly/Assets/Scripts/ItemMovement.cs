using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMovement : MonoBehaviour {

    // conveyer belt variables
    float _beltForceX;
    float _beltForceY;
    public float _beltForce;
    public Rigidbody2D parts;

    public bool isDown;

    void Start()
    {
        
        if (isDown == true)
        {
            _beltForceY += _beltForce;
            _beltForceX = 0;
        }
        else
        {
            _beltForceX += _beltForce;
            _beltForceY = 0;
        }

    }

    void Update()
    {
        //parts.MovePosition(new Vector2(parts.position.x + _beltForceX, parts.position.y + _beltForceY) * Time.fixedDeltaTime);
        parts.velocity = new Vector2(parts.position.x + _beltForceX, parts.position.y + _beltForceY) * Time.fixedDeltaTime;
        if (Input.GetKeyDown("space"))
        {
            print("space key was pressed");
            parts.velocity = Vector3.zero;

        }
   }
}

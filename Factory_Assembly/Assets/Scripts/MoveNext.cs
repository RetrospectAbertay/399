using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNext : MonoBehaviour {
    float _beltForceX;
    float _beltForceY;
    public float _beltForce;
    public Rigidbody2D parts;

    // Use this for initialization
    void Start () {
        parts.velocity = new Vector2(0, 0);

    }
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown("a"))
        {
            Debug.Log("a is pressed");
			parts.velocity = new Vector2(parts.position.x + _beltForceX, parts.position.y + _beltForceY) * Time.fixedDeltaTime;
        }
        
    }
}

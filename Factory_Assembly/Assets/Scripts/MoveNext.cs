using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNext : MonoBehaviour
{
    SpriteChange spriteChange;
    float _beltForceX;
    float _beltForceY;
    public float _beltForce;

    public Rigidbody2D parts; 
    public string inputKey;
    bool canMove;

    // Use this for initialization
    void Start()
    {
        canMove = false;

        //this.GetComponent<SpriteChange>();

        _beltForceX = 0;

        //canMove = spriteChange.getBool();
    }

    // Update is called once per frame
    void Update()
    {
        parts.velocity = new Vector2(_beltForce, -_beltForce) * Time.fixedDeltaTime;
        canMove = this.GetComponent<SpriteChange>().getBool();
        if(canMove == true)
        {
          //  Debug.Log("Can Move");
        }

        if (Input.GetKeyDown(inputKey) && canMove == true)
        { //pressed = true;
            Debug.Log(inputKey + " is pressed");
            _beltForceX = _beltForce;
            Debug.Log(parts.velocity);
        }

    }
   
}

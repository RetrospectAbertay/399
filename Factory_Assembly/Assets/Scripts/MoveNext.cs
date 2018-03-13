using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNext : MonoBehaviour
{
    float _beltForceX;
    float _beltForceY;
    public float _beltForce;
    public Rigidbody2D parts; 
    public string inputKey;
    //bool pressed = false;

    // Use this for initialization
    void Start()
    {
        
        _beltForceX = 0;
    }

    // Update is called once per frame
    void Update()
    {
        parts.velocity = new Vector2(this.transform.position.x + _beltForceX, this.transform.position.y) * Time.fixedDeltaTime;

        if (Input.GetKeyDown(inputKey))
        {
            //pressed = true;
            Debug.Log(inputKey + " is pressed");
            _beltForceX = _beltForce;
            Debug.Log(parts.velocity);
        }

    }
   
}

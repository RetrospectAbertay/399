using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNext : MonoBehaviour
{
    float _beltForceX;
    public float _beltForce;
    public Rigidbody2D parts;
    public string inputKey;
    bool canMove;
    SpriteChange change;
    //bool pressed = false;

    // Use this for initialization
    void Start()
    {
        change = this.GetComponent<SpriteChange>();
        canMove = false;
        _beltForceX = 0;
    }

    // Update is called once per frame
    void Update()
    {
        parts.velocity = new Vector2(this.transform.position.x + _beltForceX, this.transform.position.y) * Time.fixedDeltaTime;
        if (Input.GetKeyDown(inputKey))
        {
            canMove = change.getBool();
            Debug.Log(canMove);
            if (canMove == true)
            {
                canMove = false;
                //pressed = true;
                Debug.Log(inputKey + " is pressed");
                _beltForceX += _beltForce;
                Debug.Log(parts.velocity);
            }
        }
    }
}


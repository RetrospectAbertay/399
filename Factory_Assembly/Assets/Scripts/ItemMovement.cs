using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMovement : MonoBehaviour {

    // conveyer belt variables
    float _beltForceX;
    float _beltForceY;
    public float _beltForce;

    public bool isUp;

    void Start()
    {
       /* switch (isUp)
        {
            case false:
                _beltForceY += _beltForce;
                break;
            default:
                _beltForceX += _beltForce;
                break;
        }*/
        if(isUp == true)
        {
            _beltForceY += _beltForce;
        }
        else
            _beltForceX += _beltForce;

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Belt")
        {
            this.transform.position = new Vector2(this.transform.position.x + _beltForceX, this.transform.localPosition.y + _beltForceY);
        }
    }
    
}

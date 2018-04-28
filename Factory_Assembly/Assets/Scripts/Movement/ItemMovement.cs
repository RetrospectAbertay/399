using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMovement : MonoBehaviour
{

    public float _beltForce;
    public Rigidbody2D parts;

    Timer time;
    GameObject timeGameObject;

    void Start()
    {
        timeGameObject = GameObject.Find("Time");
        time = timeGameObject.GetComponent<Timer>();
        parts = GetComponent<Rigidbody2D>();
        parts.constraints = RigidbodyConstraints2D.FreezePositionY;

       if (time.GetTime() > 60)
        {
            _beltForce = 40;
        }
        else if (time.GetTime() <= 60 && time.GetTime() > 30)
       {
            _beltForce = _beltForce + 30;
        }
        else if (time.GetTime() <= 30 && time.GetTime() > 20)
        {
            _beltForce = _beltForce + 50;
        }
        else if (time.GetTime() <= 20 && time.GetTime() > 10)
        {
            _beltForce = _beltForce + 80;
        }
        else if (time.GetTime() <= 10)
        {
            _beltForce = _beltForce + 120;
        }

    }

    void Update()
    {

        parts.velocity = new Vector2(_beltForce, -_beltForce * 8) * Time.fixedDeltaTime;

    }
}
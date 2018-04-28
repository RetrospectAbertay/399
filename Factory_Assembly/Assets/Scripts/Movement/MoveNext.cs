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

    DisableTriggers disableTriggers;
    GameObject triggerGameObject;
    public string triggerName;

    Timer time;
    GameObject timeGameObject;

    // Use this for initialization
    void Start()
    {
        timeGameObject = GameObject.Find("Time");
        time = timeGameObject.GetComponent<Timer>();

        canMove = false;
        triggerGameObject = GameObject.Find(triggerName);

        if (time.GetTime() <= 60 && time.GetTime() > 30)
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
        else if (time.GetTime() <= 10 && time.GetTime() > 0)
        {
            _beltForce = _beltForce + 120;
        }

    }

    // Update is called once per frame
    void Update()
    {


        parts.velocity = new Vector2(_beltForce, -_beltForce * 8) * Time.fixedDeltaTime;
        //parts.transform.Translate(new Vector3(_beltForceX, -_beltForceX, 0) * Time.fixedDeltaTime);
        canMove = this.GetComponent<SpriteChange>().getBool();

        if (Input.GetKeyDown(inputKey) && canMove == true)
        { //pressed = true;
            disableTriggers = triggerGameObject.GetComponent<DisableTriggers>();

            _beltForceX = _beltForce;

            disableTriggers.reActivateCollider();
        }

    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMovement : MonoBehaviour {

    // conveyer belt variables
    float _beltForceX;
    float _beltForceY;
    public float _beltForce;

    public bool isUp;
    public bool isLeft;

    void Start()
    {
        switch (isUp)
        {
            case false:
                _beltForceY = _beltForce;
                break;
           /* case 2:
                _beltForceY = -_beltForce;
                break;
            case 3:
                _beltForceX = -_beltForce;
                break;*/
            default:
                _beltForceX = _beltForce;
                break;
        }

       /* if (itemType == WorkBench.SpectrumPart.FinishedSpectrum)
        {
            Debug.Log("box has spawned!");
        }*/
    }

    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "Belt")
        {
            //_onBelt = true;
            this.transform.position = new Vector3(this.transform.position.x + _beltForceX, this.transform.localPosition.y + _beltForceY, this.transform.position.z);
        }
    }
    
}

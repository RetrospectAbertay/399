using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinParts : MonoBehaviour {

   // public GameObject parts;
    void OnCollision2D(Collision2D other)
    {
            if (other.gameObject.tag == "Bin")
            {
                //Debug.Log("Contact");
               // GameObject.Destroy(parts);
            }
        }
}

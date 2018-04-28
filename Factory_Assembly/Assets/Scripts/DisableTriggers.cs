using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableTriggers : MonoBehaviour
{
    public void deactivateCollider()
    {
        this.GetComponent<Collider2D>().enabled = false;
    }

    public void reActivateCollider()
    {
        this.GetComponent<Collider2D>().enabled = true;
    }
}

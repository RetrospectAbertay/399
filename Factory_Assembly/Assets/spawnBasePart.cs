using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBasePart : MonoBehaviour {
    public Transform[] spawnPoint;
    public GameObject spawnPrefab;
    GameObject spawnClone;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        spawnClone = Instantiate(spawnPrefab, spawnPoint[0].transform.position, Quaternion.Euler(0, 0, 0));
    }
}

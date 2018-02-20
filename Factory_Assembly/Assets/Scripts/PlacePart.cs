using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum state{pause,go};

public class PlacePart : MonoBehaviour {
    public bool scorePoint;
    public int scoreValue;
    public Transform[] spawnPoint;
    public GameObject[] spawnPrefab;
    public GameObject[] spawnClone;

	state currentState;

	// Use this for initialization
    void Start () {
		currentState = state.go;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerStay2D(Collider2D other)
    {
        /*for (int i = 0; i < partGo.Length; i++)
        {
            Debug.Log("Triggered!");
            DestroyImmediate(partGo[i].gameObject, true);
        }*/
        if (other.gameObject.tag == "bottom" && Input.GetKeyDown("space"))
        {
           // Debug.Log("Space");
            Destroy(this.gameObject, 0);
			Destroy (other.gameObject, 0);
            SpawnItem();
			currentState = state.pause;
            if (scorePoint == true)
            {
                Score.score += scoreValue;
            }
        }
    }
	void SpawnItem()
	{
		spawnClone[0] = Instantiate(spawnPrefab[0], spawnPoint[0].transform.position, Quaternion.Euler(0, 0, 0));
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacePart : MonoBehaviour {
    public bool scorePoint;
    public int scoreValue;
  
    public GameObject spawnPrefab;
    public GameObject spawnClone;
    // Use this for initialization
    void Start () {
		
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
        if (other.gameObject.tag == "Place" && Input.GetKeyDown("space"))
        {
           // Debug.Log("Space");
            Destroy(this.gameObject, 0);
            SpawnItem();
            if (scorePoint == true)
            {
                Score.score += scoreValue;
            }
        }
    }
    void SpawnItem()
    {
        spawnClone = Instantiate(spawnPrefab, new Vector3(3/2,-(1/2),-1), Quaternion.Euler(0, 0, 0));
    }
}

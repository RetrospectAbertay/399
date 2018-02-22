 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public enum state{pause,go};

public class PlacePart : MonoBehaviour {
    public bool scorePoint;
    public int scoreValue;
    public Rigidbody2D[] part;

	// Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        
        /*for (int i = 0; i < partGo.Length; i++)
        {
            Debug.Log("Triggered!");
            DestroyImmediate(partGo[i].gameObject, true);
        }*/
        if (other.gameObject.tag == "Parts")
        {
            Debug.Log("j");
            if (Input.GetKeyDown("a"))
            {
                Debug.Log("a");
                // Destroy(this.gameObject, 0);
                //Destroy (other.gameObject, 0);
                part[0].velocity = new Vector2(part[0].position.x, part[0].position.y + 40) * Time.fixedDeltaTime;

                if (scorePoint == true)
                {
                    Score.score += scoreValue;
                }
            }
        }
    }
	
}

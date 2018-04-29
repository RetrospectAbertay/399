using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log("Scene Change");
		SceneManager.LoadScene("StartMenu");
	}

	// Update is called once per frame
	void Update () {
		
	}
}

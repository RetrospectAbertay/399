using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuCheckIn : MonoBehaviour {

	public Text menuText;
	public Text player1Text;
	public Text player2Text;
	public Text player3Text;
	public bool player1;
	bool player2;
	bool player3;

	// Use this for initialization
	void Start () 
	{
		player1 = false;
		player2 = false;
		player3 = false;
		player1Text.gameObject.SetActive (false);
		player2Text.gameObject.SetActive (false);
		player3Text.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown ("a")) 
		{
			player1 = true;
		}
		if (Input.GetKeyDown ("d")) 
		{
			player2 = true;
		}
		if (Input.GetKeyDown ("g")) 
		{
			player3 = true;
		}

		if (player1 == true) 
		{
			player1Text.gameObject.SetActive (true);
			menuText.gameObject.SetActive (false);
		}
		if (player2 == true) 
		{
			player2Text.gameObject.SetActive (true);
			menuText.gameObject.SetActive (false);
		}
		if (player3 == true) 
		{
			player3Text.gameObject.SetActive (true);
			menuText.gameObject.SetActive (false);
		}

		if (player1 == true && player2 == true && player3 == true)
		{
			SceneManager.LoadScene("Game_Scene");
		}

	}
}

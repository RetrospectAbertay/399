using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuCheckIn : MonoBehaviour {

	public Text menuText;

    public Image player1text;
    public Image player2text;
    public Image player3text;
    public Image player1;
    public Image player2;
    public Image player3;
    public Sprite player1textsprite;
    public Sprite player2textsprite;
    public Sprite player3textsprite;
    public Sprite player1sprite;
    public Sprite player2sprite;
    public Sprite player3sprite;
    public bool player1ready;
	bool player2ready;
	bool player3ready;

	// Use this for initialization
	void Start () 
	{
        player1ready = false;
        player2ready = false;
        player3ready = false;

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown ("a")) 
		{
			player1ready = true;
		}
		if (Input.GetKeyDown ("d")) 
		{
			player2ready = true;
		}
		if (Input.GetKeyDown ("g")) 
		{
			player3ready = true;
		}

		if (player1ready == true) 
		{
            player1text.sprite = player1textsprite;
            player1.sprite = player1sprite;

            menuText.gameObject.SetActive (false);
		}
		if (player2ready == true) 
		{
            player2text.sprite = player2textsprite;
            player2.sprite = player2sprite;
            menuText.gameObject.SetActive (false);
		}
		if (player3ready == true) 
		{
            player3text.sprite = player3textsprite;
            player3.sprite = player3sprite;
            menuText.gameObject.SetActive (false);
		}

		if (player1ready == true && player2ready == true && player3ready == true)
		{
			SceneManager.LoadScene("Game_Scene");
		}

	}
}

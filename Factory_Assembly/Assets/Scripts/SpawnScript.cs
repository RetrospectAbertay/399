﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour {


    public Transform[] spawnPoint;
    public GameObject[] spawnPrefab;
    public GameObject[] spawnClone;
    public float MaxTime;
    private float timer;
    private bool stop;
    public float wait;
    public bool partSpawner;
	//state currentstate;

    void Start()
    {
        timer = MaxTime;
//		currentstate = state.go;
    }

    void Update()
    {
        if (partSpawner == true)
        {
            timer -= (10 * Time.deltaTime);
            if (Input.GetKeyDown("space"))
            {
                stop = true;
            }
            if (Input.GetKeyUp("space"))
            {
                stop = false;
            }

            if (timer <= 0 && stop == false)
            {
                SpawnItem();
                timer = MaxTime;
            }
        }
    }

    void SpawnItem()
    {
		//if (currentstate == state.go) {
		//	Debug.Log ("go");
			spawnClone [0] = Instantiate (spawnPrefab [Random.Range (0, 0)], spawnPoint [0].transform.position, Quaternion.Euler (0, 0, 0));
		//} 


        
    }
    void Timer()
    {

    }

}

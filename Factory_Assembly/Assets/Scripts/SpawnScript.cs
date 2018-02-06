using System.Collections;
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

    void Start()
    {
        timer = MaxTime;
    }

    void Update()
    {
        timer -= (10 * Time.deltaTime);
        if(Input.GetKeyDown("space"))
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

    void SpawnItem()
    {
        spawnClone[0] = Instantiate(spawnPrefab[Random.Range(0, 0)], spawnPoint[0].transform.position, Quaternion.Euler(0, 0, 0));
    }
    void Timer()
    {

    }

}

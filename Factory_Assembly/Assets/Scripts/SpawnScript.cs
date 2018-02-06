using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour {


    public Transform[] spawnPoint;
    public GameObject[] spawnPrefab;
    public GameObject[] spawnClone;
    public float MaxTime;
    private float timer;

    void Start()
    {
        timer = MaxTime;
    }

    void Update()
    {
        timer -= (10 * Time.deltaTime);

        if (timer <= 0)
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

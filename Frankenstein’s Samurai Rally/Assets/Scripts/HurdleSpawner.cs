﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D.Animation;
using UnityEngine.UIElements;

public class HurdleSpawner : MonoBehaviour
{
    public float hurdleSpawnDelay = 2f;
    public GameObject hurdle0;
    public GameObject hurdle1;
    //public GameObject hurdle2;

    public GameObject harmlessHurdle0;
    public GameObject harmlessHurdle1;
    //public GameObject harmlessHurdle2;

    private Vector3 playerPos;
    public GameObject player;

    private float spawnDelay;

    private float[] pathArray;
    private GameObject[] hurdleArray0;
    private GameObject[] hurdleArray1;

    // Start is called before the first frame update
    void Start()
    {
        hurdleArray0 = new GameObject[2];
        hurdleArray0[0] = hurdle0;
        hurdleArray0[1] = harmlessHurdle0;

        hurdleArray1 = new GameObject[2];
        hurdleArray1[0] = hurdle1;
        hurdleArray1[1] = harmlessHurdle1;

        pathArray = new float[3];
        pathArray[0] = 0f;
        pathArray[1] = -1f;
        pathArray[2] = -1.97f;

        spawnDelay = hurdleSpawnDelay;
    }

    // Update is called once per frame
    void Update()
    {
        spawnDelay -= Time.deltaTime;
        if(spawnDelay <= 0)
        {
            spawnHurdle();
            spawnDelay = hurdleSpawnDelay;
        }

        //playerPos = player.transform.position;
    }

    void spawnHurdle()
    {
        int lane = Random.Range(0, 3);
        if(lane == 0)
        {
            int number = Random.Range(0, 2);
            Instantiate(hurdleArray0[number], new Vector3(8.1f, pathArray[lane], 0), Quaternion.identity);
        } else if(lane == 1 || lane == 2)
        {
            int number1 = Random.Range(0, 2);
            Instantiate(hurdleArray1[number1], new Vector3(8.1f, pathArray[lane], 0), Quaternion.identity);
        }/*else if(lane == 1 && playerPos.y <= 1.5f)
        {
            Debug.Log("jest ponizej");
            Instantiate(hurdle2, new Vector3(8.1f, pathArray[lane], 0), Quaternion.identity);
        }*/
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpoilsSpawner : MonoBehaviour
{
    public GameObject[] spoils;
    public int minDelay;
    public int maxDelay;

    private float delay;

    void Start()
    {
        delay = Random.Range(minDelay, maxDelay);
    }

    // Update is called once per frame
    void Update()
    {
        delay -= Time.deltaTime;
        if (delay <= 0)
        {
            delay = Random.Range(minDelay, maxDelay);
            SpawnSpoils();
        }
    }

    void SpawnSpoils()
    {
        Instantiate(spoils[(int)Random.Range(0, 3)], new Vector3(7.93f, Random.Range(0f, -2.55f), 0f), Quaternion.identity);
    }
}

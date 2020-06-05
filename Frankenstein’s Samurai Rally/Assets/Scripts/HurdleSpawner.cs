using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurdleSpawner : MonoBehaviour
{
    public float hurdleSpawnDelay = 2f;
    public GameObject hurdle;
    private float spawnDelay;

    private float[] pathArray;

    // Start is called before the first frame update
    void Start()
    {
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
    }

    void spawnHurdle()
    {
        int lane = Random.Range(0, 3);

        Instantiate(hurdle, new Vector3(8.1f, pathArray[lane], 0), Quaternion.identity);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballSpawner : MonoBehaviour
{
    public float hurdleSpawnDelay = 2f;
    public GameObject hurdle;
    private float spawnDelay;

    // Start is called before the first frame update
    void Start()
    {
        spawnDelay = hurdleSpawnDelay;
    }

    // Update is called once per frame
    void Update()
    {
        spawnDelay -= Time.deltaTime;
        if (spawnDelay <= 0)
        {
            spawnHurdle();
            spawnDelay = hurdleSpawnDelay;
        }
    }

    void spawnHurdle()
    {
        Instantiate(hurdle, new Vector3(0.1f, 4.92f, 0), Quaternion.identity);
    }
}

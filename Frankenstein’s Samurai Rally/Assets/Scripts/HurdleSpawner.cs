using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D.Animation;
using UnityEngine.UIElements;

public class HurdleSpawner : MonoBehaviour
{
    public float hurdleSpawnDelay = 2f;
    public GameObject hurdle0;
    public GameObject hurdle1;
    public GameObject hurdle2;

    private Vector3 playerPos;
    public GameObject player;

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

        playerPos = player.transform.position;
    }

    void spawnHurdle()
    {
        int lane = Random.Range(0, 3);
        if(lane == 0)
        {
            Instantiate(hurdle0, new Vector3(8.1f, pathArray[lane], 0), Quaternion.identity);
        } else if(lane == 1 || lane == 2)
        {
            Instantiate(hurdle1, new Vector3(8.1f, pathArray[lane], 0), Quaternion.identity);
        }/*else if(lane == 1 && playerPos.y <= 1.5f)
        {
            Debug.Log("jest ponizej");
            Instantiate(hurdle2, new Vector3(8.1f, pathArray[lane], 0), Quaternion.identity);
        }*/
    }
}

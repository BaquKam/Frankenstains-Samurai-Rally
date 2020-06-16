using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonuses : MonoBehaviour
{
    [Header("Type of bonus")]
    public bool isShield;

    [Header("Bonuses Settings")]
    public float bonusSpeed = 10f;

    [Header("Shield Settings")]
    public GameObject shield;
    public GameObject enemy;
    private GameObject player;
    private Vector3 playerPos;


    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Translate(new Vector3(-1, 0, 0) * bonusSpeed * Time.deltaTime);        
    }

    private void OnTriggerEnter2D(Collider2D obj)
    {
        if(obj.gameObject.tag == "Player")
        {
            if(isShield == true)
            {
                player = GameObject.FindWithTag("Player");
                obj.gameObject.tag = "Shield";

                enemy.gameObject.tag = "Proof";

                playerPos = player.transform.position;
                playerPos.z = -0.1f;
                GameObject shieldObj = (GameObject)Instantiate(shield, playerPos, Quaternion.identity);
                shieldObj.transform.parent = player.transform;
                Destroy(this.gameObject);
            }
        }
        else if (obj.gameObject.tag == "ObjectDestroyer")
        {
            Destroy(this.gameObject);
        }
    }
}

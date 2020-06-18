using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonuses : MonoBehaviour
{
    [Header("Type of bonus")]
    public bool isShield;
    public bool isAttack;

    [Header("Bonuses Settings")]
    public float bonusSpeed = 10f;
    private GameObject player;
    public GameObject enemy;
    private GameObject[] enemytab;
    private AudioSource source;

    [Header("Shield Settings")]
    public GameObject shield;
    private Vector3 playerPos;
    public AudioClip shieldSound;

    [Header("Attack Settings")]
    public GameObject attack;
    private Vector3 playerPosAttack;
    public AudioClip attackSound;

    private void Start()
    {
        source = gameObject.GetComponent<AudioSource>();
    }

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
                source.PlayOneShot(shieldSound, 0.77f);

                player = GameObject.FindWithTag("Player");
                //obj.gameObject.tag = "Shield";

                enemytab = GameObject.FindGameObjectsWithTag("Hurdle");

                for (int i = 0; i < enemytab.Length; i++)
                {
                    enemytab[i].gameObject.tag = "Proof";
                }
                enemy.gameObject.tag = "Proof";

                playerPos = player.transform.position;
                playerPos.z = 89f;
                GameObject shieldObj = (GameObject)Instantiate(shield, playerPos, Quaternion.identity);
                shieldObj.transform.parent = player.transform;
                Destroy(this.gameObject);
            }else if (isAttack == true)
            {
                source.PlayOneShot(attackSound, 0.77f);

                player = GameObject.FindWithTag("Player");
                obj.gameObject.tag = "Attack";

                enemytab = GameObject.FindGameObjectsWithTag("Hurdle");

                for (int i = 0; i < enemytab.Length; i++)
                {
                    enemytab[i].gameObject.tag = "Proof";
                }
                enemy.gameObject.tag = "Proof";
                playerPosAttack = player.transform.position;
                playerPos.z = 89f;
                GameObject attackObj = (GameObject)Instantiate(attack, playerPosAttack, Quaternion.identity);
                attackObj.transform.parent = player.transform;
                Destroy(this.gameObject);
            }
        }
        else if (obj.gameObject.tag == "ObjectDestroyer")
        {
            Destroy(this.gameObject);
        }
    }
}

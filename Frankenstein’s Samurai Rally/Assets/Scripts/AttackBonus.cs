using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBonus : MonoBehaviour
{
    public float duration;
    public GameObject enemy;
    private GameObject[] enemytab;

    void Update()
    {
        duration -= Time.deltaTime;
        if (duration <= 0)
        {
            this.gameObject.transform.parent.tag = "Player";

            enemytab = GameObject.FindGameObjectsWithTag("Proof");

            for (int i = 0; i < enemytab.Length; i++)
            {
                enemytab[i].gameObject.tag = "Hurdle";
            }

            enemy.gameObject.tag = "Hurdle";
            Destroy(this.gameObject);
        }
    }
}

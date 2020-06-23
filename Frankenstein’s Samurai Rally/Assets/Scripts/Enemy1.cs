using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy1 : MonoBehaviour
{
    public float hurdleSpeed = 5f;
    private Vector3 hurdlePosition;

    public int health;

    public Text pointText;
    public Text pointTextHelp;
    private int points = 0;

    void Update()
    {
        this.gameObject.transform.Translate(new Vector3(-1, 0, 0) * hurdleSpeed * Time.deltaTime);
        
        if(health <= 0)
        {
            points += 1;
            Destroy(gameObject);
        }
        pointText.text = "Spoils: " + points.ToString();
        pointTextHelp.text = points.ToString();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Attack")
        {
            Destroy(gameObject);
        }
        else if (other.gameObject.tag == "ObjectDestroyer")
        {
            Destroy(this.gameObject);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
    }
}

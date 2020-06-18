using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float hurdleSpeed = 5f;
    private Vector3 hurdlePosition;

    void Update()
    {
        this.gameObject.transform.Translate(new Vector3(-4, -1, 0) * hurdleSpeed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "ObjectDestroyer")
        {
            Destroy(this.gameObject);
        }
    }
}

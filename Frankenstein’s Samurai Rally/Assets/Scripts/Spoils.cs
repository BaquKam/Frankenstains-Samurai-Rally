using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spoils : MonoBehaviour
{
    public float spoilSpeed = 5f;
    private Vector3 spoilPosition;

    void Update()
    {
        this.gameObject.transform.Translate(new Vector3(-1, 0, 0) * spoilSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "ObjectDestroyer")
        {
            Destroy(this.gameObject);
        }
    }
}

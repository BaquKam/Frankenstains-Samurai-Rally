using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    //private Transform target;
    private Vector2 target;

    void Start()
    {
        //target = GameObject.FindGameObjectWithTag("Finish").GetComponent<Transform>();
        target = new Vector2(36.38f, 0f);
    }

    void Update()
    {
        //transform.position = new Vector3(transform.position.x * speed * Time.deltaTime, transform.position.y);
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

    }

}

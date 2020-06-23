using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchController : MonoBehaviour
{
    private float screenHeight;
    private float screenWidth;
    public float speed = 10f;
    private Vector3 velocity;
    public GameObject player;

    void Start()
    {
        screenHeight = Screen.height;
        screenWidth = Screen.width;
        velocity = transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            Vector3 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            touchPos.z = 0;

            if (touch.position.y < screenHeight / 2 && touch.position.x > screenWidth / 3 && touch.phase == TouchPhase.Began)
            {
                if (velocity.y > -2)
                {
                    velocity += Vector3.down;
                }
            }

            if (touch.position.y > screenHeight / 2 && touch.position.x > screenWidth / 3 && touch.phase == TouchPhase.Began)
            {
                if (velocity.y < 0)
                {
                    velocity += Vector3.up;
                }
            }

        }
        transform.position = Vector3.Lerp(transform.position, velocity, speed * Time.deltaTime);
    }
}

//transform.position = Vector3.Lerp(transform.position, velocity, speed* Time.deltaTime);

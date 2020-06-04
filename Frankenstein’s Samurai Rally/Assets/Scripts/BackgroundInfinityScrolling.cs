using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundInfinityScrolling : MonoBehaviour
{
    public float scrollSpeed;
    private Vector2 offset;

    // Update is called once per frame
    void Update()
    {
        offset = new Vector2(Time.time * scrollSpeed, 0);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}

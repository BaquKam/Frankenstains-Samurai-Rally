using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstHurdle : MonoBehaviour
{
    public float hurdleSpeed = 5f;
    private Vector3 hurdlePosition;

    void Update()
    {
        this.gameObject.transform.Translate(new Vector3(-1, 0, 0) * hurdleSpeed * Time.deltaTime);
    }

}

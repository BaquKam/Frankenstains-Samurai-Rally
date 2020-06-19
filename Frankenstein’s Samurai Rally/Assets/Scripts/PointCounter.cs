using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointCounter : MonoBehaviour
{
    public Text pointText;
    public Text pointTextHelp;
    private int points = 0;
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        pointText.text = "Spoils: " + points.ToString();
        pointTextHelp.text = points.ToString();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Spoils")
        {
            points += 1;
            Destroy(other.gameObject);
        }else if (other.gameObject.tag == "Proof" && player.tag == "Attack")
        {
            points += 1;
        }
    }
}

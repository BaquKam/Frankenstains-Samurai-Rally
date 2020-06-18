using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionDetect : MonoBehaviour
{
    public GameObject gameOverPanel;
    public Text gameScore;
    public Text endScore;
    private void Start()
    {
        gameOverPanel.gameObject.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Hurdle")
        {
            endScore.text = gameScore.text;
            gameOverPanel.gameObject.SetActive(true);
            Destroy(gameObject);
        }else if (other.gameObject.tag == "ObjectDestroyer")
        {
            Destroy(this.gameObject);
        }
    }
}

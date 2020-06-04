using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionDetect : MonoBehaviour
{
    public GameObject gameOverPanel;
    //public Text gameScore;
    //public Text endScore;
    void Start()
    {
        gameOverPanel.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.gameObject.tag == "Hurdle")
        {
            //endScore.text = gameScore.text;
            gameOverPanel.gameObject.SetActive(true);
            Destroy(gameObject);
        }else if (obj.gameObject.tag == "ObjectDestroyer")
        {
            Destroy(this.gameObject);
        }
    }
}

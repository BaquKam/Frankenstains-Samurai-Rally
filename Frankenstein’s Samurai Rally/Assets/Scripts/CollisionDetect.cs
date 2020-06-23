using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionDetect : MonoBehaviour
{
    public GameObject gameOverPanel;
    public Text gameScore;
    public Text endScore;

    private AudioSource source;
    public AudioClip sound;

    private void Start()
    {
        gameOverPanel.gameObject.SetActive(false);
        source = gameObject.GetComponent<AudioSource>();

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Hurdle" || other.gameObject.tag == "Hurdle1")
        {
            endScore.text = gameScore.text;
            gameOverPanel.gameObject.SetActive(true);
            Destroy(gameObject);
        }else if (other.gameObject.tag == "ObjectDestroyer")
        {
            Destroy(this.gameObject);
        }

        if(other.gameObject.tag == "Bonus")
        {
            source.PlayOneShot(sound, 0.3f);
        }
    }
}

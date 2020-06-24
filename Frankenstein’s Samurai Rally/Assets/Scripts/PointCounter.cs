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

    private AudioSource source;
    public AudioClip sound;
    public AudioClip soundAttack;

    private void Start()
    {
        source = gameObject.GetComponent<AudioSource>();
    }

    void Update()
    {
        pointText.text = "Spoils: " + points.ToString();
        pointTextHelp.text = points.ToString();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Spoils")
        {
            source.PlayOneShot(sound, 0.3f);
            points += 1;
            Destroy(other.gameObject);
        }else if (other.gameObject.tag == "Proof" && player.tag == "Attack")
        {
            source.PlayOneShot(soundAttack, 0.3f);
            points += 1;
        }
    }
    public void AttackPoint(int number)
    {
        points += (number - 1);
    }
}

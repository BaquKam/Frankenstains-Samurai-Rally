using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private float screenWidth;

    private float timeBtwAttack;
    public float startTimeBtwAttack;

    public Transform attackPos;
    public LayerMask whatIsEnemies;
    public float attackRangeX;
    public float attackRangeY;
    public int damage;

    private int points = 0;
    public PointCounter function;

    private AudioSource source;
    public AudioClip sound;

    public Animator playerAnim;

    void Start()
    {
        screenWidth = Screen.width;
        source = gameObject.GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            Vector3 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            touchPos.z = 0;

            if (touch.position.x < screenWidth / 3 && touch.phase == TouchPhase.Began)
            {
                //Debug.Log("tap");

                if (timeBtwAttack <= 0)
                {
                    source.PlayOneShot(sound, 0.3f);
                    playerAnim.SetTrigger("Attack");
                    Collider2D[] enemiesToDamage = Physics2D.OverlapBoxAll(attackPos.position, new Vector2(attackRangeX, attackRangeY), 0, whatIsEnemies);
                    for (int i = 0; i < enemiesToDamage.Length; i++)
                    {
                        enemiesToDamage[i].GetComponent<Enemy1>().TakeDamage(damage);
                        points += 1;
                        function.AttackPoint(points);
                    }
                    points = 0;
                    timeBtwAttack -= startTimeBtwAttack;
                }
                else
                {
                    timeBtwAttack -= Time.deltaTime;
                }
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(attackPos.position, new Vector3(attackRangeX, attackRangeY));
    }
}

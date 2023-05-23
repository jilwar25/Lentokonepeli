using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_3 : MonoBehaviour
{
    public float speed = 150.0f;
    public float dashSpeed = 300.0f;
    public int maxHealth = 2;
    private int currentHealth;
    public Transform player;
    private Rigidbody2D rb;
    private Vector2 screenBounds;
    private bool isDashing = false;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
       // Debug.Log("Enemy " + screenBounds);
    }


    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < screenBounds.x / 2 && !isDashing)
        {
            DashTowardsPlayer();
        }
     //   Debug.Log(transform.position);
        if (transform.position.x < -5)
        {
            Destroy(this.gameObject);
        }
    }

    void DashTowardsPlayer()
    {
        {
            // Debug.Log("dash check");
            Vector2 playerScreenPos = Camera.main.WorldToScreenPoint(player.position);
            Vector2 enemyScreenPos = Camera.main.WorldToScreenPoint(transform.position);
            Vector2 direction = (playerScreenPos - enemyScreenPos).normalized;
            rb.velocity = direction * dashSpeed;
            isDashing = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(collision.gameObject);
            TakeDamage(1);
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        GetComponent<Lootbag>().InstantiateLoot(transform.position);
        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Enemy_2 : MonoBehaviour
{
    public float speed = 150.0f;
    public int maxHealth = 2;
    private int currentHealth;
    private Rigidbody2D rb;
    private Vector2 screenBounds;
    private float nextChangeTime;
    private int direction;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        SetNextChangeTime();
        int direction = Random.Range(-1, 2);
       // Debug.Log(direction);
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, direction * speed);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        // Debug.Log("Enemy " + screenBounds);
    }


    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextChangeTime)
        {
            direction = Random.Range(-1, 2);
            SetNextChangeTime();
            rb.velocity = new Vector2(rb.velocity.x, direction * speed);

        }
        if (transform.position.y >= screenBounds.y)
        {
            rb.velocity = new Vector2(-speed, -1 * speed);
        }
        if (transform.position.y <= 0)
        {
            rb.velocity = new Vector2(-speed, 1 * speed);
        }
       // Debug.Log("pos " + transform.position);
       // Debug.Log("scbound " + screenBounds);
        if (transform.position.x < -5)
        {
            Destroy(this.gameObject);
        }
    }

    void SetNextChangeTime()
    {
        float randomTime = Random.Range(0.5f, 2f);
        nextChangeTime = Time.time + randomTime;
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
        if(currentHealth <= 0)
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

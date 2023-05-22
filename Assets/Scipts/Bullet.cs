using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float bulletSpeed = 300.0f;
    public float bulletLifeTime = 4.0f;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(gameObject, bulletLifeTime);
    }

    private void FixedUpdate()
    {
        rb.velocity = transform.right * bulletSpeed;
    }
}

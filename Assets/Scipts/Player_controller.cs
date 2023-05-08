using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class Player_controller : MonoBehaviour
{
    public GameObject enemy;
    public float speed = 50f;
    private Rigidbody2D rb;
    Vector2 moveInput;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(0, moveInput.y * speed);
    }

    public void OnUp(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Started)
        {
            Debug.Log("up");
            float moveY = context.ReadValue<float>();
            moveInput.y = moveY;
        }
        else if(context.phase == InputActionPhase.Canceled)
        {
            moveInput.y = 0;
        }
    }
    public void OnDown(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Started)
        {
            Debug.Log("down");
            float moveY = context.ReadValue<float>();
            moveInput.y = -moveY;
        }
        else if (context.phase == InputActionPhase.Canceled)
        {
            moveInput.y = 0;
        }
    }
    public void OnShoot(InputAction.CallbackContext context)
    {
        // Ampuu
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Time.timeScale = 0;
        }
    }
}
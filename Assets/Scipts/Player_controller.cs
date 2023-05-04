using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class Player_controller : MonoBehaviour
{
    public float speed = 1f;
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
        Debug.Log("up");
        float moveY = context.ReadValue<float>();
        moveInput.y = moveY;
    }
    public void OnDown(InputAction.CallbackContext context)
    {
        Debug.Log("down");
        float moveY = context.ReadValue<float>();
        moveInput.y = -moveY;
    }
    public void OnShoot(InputAction.CallbackContext context)
    {
        // Ampuu
    }
}
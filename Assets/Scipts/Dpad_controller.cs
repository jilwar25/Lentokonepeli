using UnityEngine;

public class DPad_controller : MonoBehaviour
{
    public static DPad_controller Instance { get; private set; }

    private Vector2 moveDir = Vector2.zero; // pelaajan liikkumissuunta

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        if (Instance == this)
        {
            Instance = null;
        }
    }

    private void Update()
    {
        // lasketaan pelaajan liikkumissuunta D-padin liikesuunnan perusteella
        moveDir.x = Input.GetAxisRaw("Horizontal");
        moveDir.y = Input.GetAxisRaw("Vertical");
        moveDir.Normalize();
    }

    private void FixedUpdate()
    {
        // liikutetaan pelaajaa pelaajan liikkumissuunnan mukaan
        Rigidbody2D playerRb = GetComponent<Rigidbody2D>();
        playerRb.MovePosition(playerRb.position + moveDir * Time.fixedDeltaTime);
    }
}
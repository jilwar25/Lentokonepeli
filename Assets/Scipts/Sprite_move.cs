using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Sprite_move : MonoBehaviour
{
    public float speed;
    float singleTextureWidth;

    private void Start()
    {
        setupTexture();
    }

    void setupTexture()
    {
        Sprite sprite = GetComponent<SpriteRenderer>().sprite;
        singleTextureWidth = sprite.texture.width;
    }

    void Scroll()
    {
        float delta = speed * Time.deltaTime;
        transform.position += new Vector3(-delta, 0, 0);
    }

    void CheckReset()
    {
        if((Mathf.Abs(transform.position.x) - singleTextureWidth) > 0)
        {
            transform.position = new Vector3(0, transform.position.y, transform.position.z);
        }
    }

    private void Update()
    {
        Scroll();
        CheckReset();
    }
}

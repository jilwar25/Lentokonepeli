using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sky_move : MonoBehaviour
{
    public float skyspeed;

    [SerializeField]
    private Renderer skyRenderer;

    // Update is called once per frame
    void Update()
    {
        skyRenderer.material.mainTextureOffset += new Vector2(skyspeed * Time.deltaTime, 0);
    }
}

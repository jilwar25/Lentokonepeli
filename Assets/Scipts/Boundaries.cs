using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    private Vector2 screenBounds;
    private float objectWidth;
    private float objectHeight;

    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));    
        objectWidth = transform.GetComponent<MeshRenderer>().bounds.extents.x;
        objectHeight = transform.GetComponent<MeshRenderer>().bounds.extents.y;
      //  Debug.Log("Screen Bounds y: " + screenBounds.y);
      //  Debug.Log("Object Height: " + objectHeight);
    }

    void LateUpdate()
    {
        Vector3 viewPos = transform.position;
        float minY = 0 + objectHeight; // float minY = screenBounds.y * -1 + objectHeight ???
        float maxY = screenBounds.y - objectHeight;
        viewPos.y = Mathf.Clamp(viewPos.y, minY, maxY);
       // Debug.Log("View Pos y: " + viewPos.y);
        transform.position = viewPos;
    }
}
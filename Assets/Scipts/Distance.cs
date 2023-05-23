using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Distance : MonoBehaviour
{
    private PlayerInventory playerInventory;
    private Vector3 lastPosition;
    private float distanceTraveled;
    private float startTime;
    public TextMeshProUGUI distanceText;
    public TextMeshProUGUI moneyText;


    void Start()
    {
        playerInventory = FindAnyObjectByType<PlayerInventory>();
        startTime = 0f;
    }

    void Update()
    {
        startTime += Time.deltaTime;
        distanceTraveled = startTime * 27; // speed on pelaajan liikkumisnopeus
        distanceText.text = "Distance: " + Mathf.RoundToInt(distanceTraveled).ToString() + "m";
        moneyText.text = "Money " + playerInventory.Money;
    }
}
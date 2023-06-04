using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laskin : MonoBehaviour

{
    private int coinCount = 0;
    private int enemyCount = 0;

    // Call this method when the player collects a coin
    public void CollectCoin()
    {
        coinCount++;
        Debug.Log("Coin Collected! Total Coins: " + coinCount);
    }

    // Call this method when the player shoots down an enemy
    public void ShootEnemy()
    {
        enemyCount++;
        Debug.Log("Enemy Shot Down! Total Enemies: " + enemyCount);
    }
}



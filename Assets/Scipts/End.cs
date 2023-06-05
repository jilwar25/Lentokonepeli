using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class End : MonoBehaviour
{

    public TextMeshProUGUI coinCountText;
    public TextMeshProUGUI enemyCountText;

    public void ShowVictoryScreen(int coinCount, int enemyCount)
    {
        coinCountText.text = "Coins Collected: " + coinCount;
        enemyCountText.text = "Enemies Shot: " + enemyCount;

        // Show the victory screen UI or perform other actions
        // You can enable a canvas or show a panel to display the victory information
    }
}



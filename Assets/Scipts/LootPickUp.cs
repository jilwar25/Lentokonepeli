using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LootPickUp : MonoBehaviour
{
    public int moneyValue = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Inventory inventory = other.GetComponent<Inventory>();

            if(inventory != null)
            {
                inventory.Money = inventory.Money + moneyValue;
                Destroy(gameObject);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour, Inventory
{
    public int Money { get => _money; set => _money = value; }

    private int _money = 0;

}

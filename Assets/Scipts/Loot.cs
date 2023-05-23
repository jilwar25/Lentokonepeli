using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Loot : ScriptableObject
{
    public Sprite lootSprite;
    public string lootName;
    public int dropRate;

    public Loot(string lootName, int dropRate)
    {
        this.lootName = lootName;
        this.dropRate = dropRate;
    }
}

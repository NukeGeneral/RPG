using UnityEngine;
using System.Collections;

public class BaseItems  {

    public enum ItemTypes {Equipment,Potion,Weapon}
    public enum ItemQualities { Common,Uncommon,Rare,Unique,Artifact }

    public ItemQualities ItemQuality
    {
        get; set;
    }
    public ItemTypes ItemType
    {
        get; set;
    }

    public string ItemName
    {
        get; set;
    }

    public string ItemDesc
    {
        get; set;
    }

    public int ItemID
    {
        get; set;
    }
}

using UnityEngine;
using System.Collections;

public class BaseEquipmentItems : BaseItemStats {

    public enum ArmorTypes { Gloves, Shoulders, Head, Chest_Armor, Belt, Legs, Feet, Waist, Ring, Necklace }
    public enum ArmorWeightTypes { Cloth,Leather,Mail }

    public ArmorTypes ArmorType
    {
        get; set;
    }

    public ArmorWeightTypes ArmorWeightType
    {
        get; set;
    }
}

using UnityEngine;
using System.Collections;

public class BaseWeaponItems : BaseItemStats {

    public enum WeaponTypes {OneHand_Sword,TwoHand_Axe,Bow,Quiver,Wand,Shield,Orb,Polearm,Staff,Fist_Weapon,Relic}
    public enum ElementTypes { Frost,Shadow,Holy,Fire,Arcane,Nature}

    // 1 Hand Sword,Shield and 2 Hand Axe for Barbarian,1 Hand Sword,Shield and Relic for Templar,Wand, Orb and Staff for Wizard,Bow and Quiver for Hunter,Wand,Relic and Staff for Cleric,Fist Weapons,1 Hand Sword and 2 Hand Axe for Monks
    public ElementTypes ElementType
    {
        get; set;
    }

    public WeaponTypes WeaponType
    {
        get; set;
    }

    public int MinDMG
    {
        get; set;
    }

    public int MaxDMG
    {
        get; set;
    }

    public float AttackSpeed
    {
        get; set;
    }
}

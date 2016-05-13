using UnityEngine;
using System.Collections;

public class MobSpreadsheet {

    public enum Affixes { Common, Elite, Champion, Rare, Boss, Legendary }

    public BaseMob MobType
    {
        get; set;
    }

    public string MobName
    {
        get; set;
    }

    public string MobAffixDesc
    {
        get; set;
    }

    public int MobLevel
    {
        get; set;
    }

    public int Stamina
    {
        get; set;
    }

    public int Intellect
    {
        get; set;
    }

    public int Agility
    {
        get; set;
    }

    public int Mana
    {
        get; set;
    }

    public int Strength
    {
        get; set;
    }

    public int FireResist
    {
        get; set;
    }

    public int ShadowResist
    {
        get; set;
    }

    public int HolyResist
    {
        get; set;
    }

    public int NatureResist
    {
        get; set;
    }

    public int FrostResist
    {
        get; set;
    }

    public int ArcaneResist
    {
        get; set;
    }

    public int Speed
    {
        get; set;
    }

    public int Health
    {
        get; set;
    }

    public Affixes AffixChoose
    {
        get; set;
    }
}

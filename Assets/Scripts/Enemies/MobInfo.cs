using UnityEngine;
using System.Collections;

public class MobInfo : MonoBehaviour {
    public enum Affixes { Common, Elite, Champion, Rare, Boss, Legendary }

    public static BaseMob MobType
    {
        get; set;
    }

    public static string MobName
    {
        get; set;
    }

    public static string MobAffixDesc
    {
        get; set;
    }

    public static int MobLevel
    {
        get; set;
    }

    public static int Stamina
    {
        get; set;
    }

    public static int Intellect
    {
        get; set;
    }

    public static int Agility
    {
        get; set;
    }

    public static int Mana
    {
        get; set;
    }

    public static int Strength
    {
        get; set;
    }

    public static int FireResist
    {
        get; set;
    }

    public static int ShadowResist
    {
        get; set;
    }

    public static int HolyResist
    {
        get; set;
    }

    public static int NatureResist
    {
        get; set;
    }

    public static int FrostResist
    {
        get; set;
    }

    public static int ArcaneResist
    {
        get; set;
    }

    public static int Speed
    {
        get; set;
    }

    public static int Health
    {
        get; set;
    }

    public static Affixes AffixChoose
    {
        get; set;
    }
}

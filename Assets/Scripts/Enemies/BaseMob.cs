using UnityEngine;
using System.Collections;

public class BaseMob  {

    public enum Affixes {Common,Elite,Champion,Rare,Boss,Legendary}

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

public class BaseMeleeMob : BaseMob
{
    public BaseMeleeMob()
    {
        Stamina = 50;
        Intellect = 5;
        Strength = 25;
        Agility = Random.Range(9, 16);
        Speed = Agility / 100;
        Mana = Intellect * 3;
        MobName = "Skeleton";
        MobAffixDesc = "Minion";
        MobLevel = 1;
        AffixChoose = BaseMob.Affixes.Common;
        ArcaneResist = 0;
        NatureResist = 0;
        HolyResist = 0;
        ShadowResist = 15;
        FireResist = 9;
        FrostResist = 2;     
    }
}

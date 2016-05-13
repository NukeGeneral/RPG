using UnityEngine;
using System.Collections;

public class BaseAbility {


    public string AbilityName
    {
        get; set;
    }

    public int AbilityDamagePercent
    {
        get; set;
    }

    public string AbilityDescription
    {
        get; set;
    }

    public int AbilityID
    {
        get; set;
    }

    public int AbilityLevelReq
    {
        get; set;
    }

    public int AbilityManaCost
    {
        get; set;
    }
}

public class AutoAttack : BaseAbility
{
    public AutoAttack()
    {
        AbilityName = "Auto Attack";
        AbilityDescription = "Auto attacks enemy based on your weapon speed";
        AbilityDamagePercent = 125;
        AbilityID = 1;
        AbilityLevelReq = 1;
        AbilityManaCost = 0;
    }
}

public class WarriorCleave : BaseAbility
{
    public WarriorCleave()
    {
        AbilityName = "Cleave";
        AbilityDescription = "Cleave enemies 10 yards of character";
        AbilityDamagePercent = 70;
        AbilityID = 2;
        AbilityLevelReq = 2;
        AbilityManaCost = 15;
    }
}

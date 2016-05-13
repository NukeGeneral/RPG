using UnityEngine;
using System.Collections;

public class BaseCharacter {

    public string CharRace
    {
        get; set;
    }

    public string CharClassName
    {
        get; set;
    }

    public string CharClassDesc
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
}

public class BaseWarrior : BaseCharacter
{

    public BaseWarrior()
    {
        CharClassName = "Warrior";
        CharClassDesc = "";
        Stamina = 100;
        Agility = 20;
        Strength = 30;
        Mana = Intellect * 3 + 10;
        Intellect = 10;
        Health = Stamina * 2 + 100;
    }
}

public class BaseWizard : BaseCharacter
{

    public BaseWizard()
    {
        CharClassName = "Wizard";
        CharClassDesc = "Kemal A.T.O.M.";
        Stamina = 100;
        Agility = 20;
        Strength = 30;
        Mana = Intellect * 3 + 10;
        Intellect = 10;
        Health = Stamina * 2 + 100;
    }
}

public class BaseTemplar : BaseCharacter
{

    public BaseTemplar()
    {
        CharClassName = "Templar";
        CharClassDesc = "";
        Stamina = 100;
        Agility = 20;
        Strength = 30;
        Mana = Intellect * 3 + 10;
        Intellect = 10;
        Health = Stamina * 2 + 100;
    }
}

public class BasePriest : BaseCharacter
{

    public BasePriest()
    {
        CharClassName = "Priest";
        CharClassDesc = "Nightmare of the undeads.";
        Stamina = 100;
        Agility = 20;
        Strength = 30;
        Mana = Intellect * 3 + 10;
        Intellect = 10;
        Health = Stamina * 2 + 100;

    }
}

public class BaseMonk : BaseCharacter
{

    public BaseMonk()
    {
        CharClassName = "Monk";
        CharClassDesc = "Onepunchman always behave like that.";
        Stamina = 100;
        Agility = 20;
        Strength = 30;
        Mana = Intellect * 3 + 10;
        Intellect = 10;
        Health = Stamina * 2 + 100;
    }
}

public class BaseHunter : BaseCharacter
{

    public BaseHunter()
    {
        CharClassName = "Hunter";
        CharClassDesc = "";
        Stamina = 100;
        Agility = 20;
        Strength = 30;
        Mana = Intellect * 3 + 10;
        Intellect = 10;
        Health = Stamina * 2 + 100;
    }
}

public class BaseHuman : BaseCharacter
{
    public BaseHuman()
    {
        FireResist = 1;
        ShadowResist = 0;
        HolyResist = 0;
        NatureResist = 2;
        FrostResist = 3;
        ArcaneResist = 0;
    }
}

public class BaseElf : BaseCharacter
{
    public BaseElf()
    {
        FireResist = 1;
        ShadowResist = 0;
        HolyResist = 0;
        NatureResist = 2;
        FrostResist = 3;
        ArcaneResist = 0;
    }
}

public class BaseHuman3 : BaseCharacter
{
    public BaseHuman3()
    {
        FireResist = 1;
        ShadowResist = 0;
        HolyResist = 0;
        NatureResist = 2;
        FrostResist = 3;
        ArcaneResist = 0;
    }
}

public class BaseHuman4 : BaseCharacter
{
    public BaseHuman4()
    {
        FireResist = 1;
        ShadowResist = 0;
        HolyResist = 0;
        NatureResist = 2;
        FrostResist = 3;
        ArcaneResist = 0;
    }
}

public class BaseHuman5 : BaseCharacter
{
    public BaseHuman5()
    {
        FireResist = 1;
        ShadowResist = 0;
        HolyResist = 0;
        NatureResist = 2;
        FrostResist = 3;
        ArcaneResist = 0;
    }
}

public class BaseHuman6 : BaseCharacter
{
    public BaseHuman6()
    {
        FireResist = 1;
        ShadowResist = 0;
        HolyResist = 0;
        NatureResist = 2;
        FrostResist = 3;
        ArcaneResist = 0;
    }
}

public class BaseHuman7 : BaseCharacter
{
    public BaseHuman7()
    {
        FireResist = 1;
        ShadowResist = 0;
        HolyResist = 0;
        NatureResist = 2;
        FrostResist = 3;
        ArcaneResist = 0;
    }
}

public class BaseHuman8 : BaseCharacter
{
    public BaseHuman8()
    {
        FireResist = 1;
        ShadowResist = 0;
        HolyResist = 0;
        NatureResist = 2;
        FrostResist = 3;
        ArcaneResist = 0;
    }
}

using UnityEngine;
using System.Collections;

public class BaseItemStats : BaseItems {

    public enum ResistTypes {Fire_Resist,Shadow_Resist,Poison_Resist,Arcane_Resist,Holy_Resist,Frost_Resist}


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

    public ResistTypes ResistType
    {
        get; set;
    }

    public int Strength
    {
        get; set;
    }

    public int Resist
    {
        get; set;
    }

    public int Health
    {
        get; set;
    }

    public int Mana
    {
        get; set;
    }

    public int Speed
    {
        get; set;
    }
}

using UnityEngine;
using System.Collections;

public class PlayerInfo : MonoBehaviour {

	void Awake()
    {
        DontDestroyOnLoad(this);
    }

    public static int PlayerLevel
    {
        get; set;
    }

    public static string PlayerName
    {
        get; set;
    }

    public static BaseCharacter PlayerClass
    {
        get; set;
    }

    public static BaseCharacter PlayerRace
    {
        get; set;
    }

    public static int CurrentXP
    {
        get; set;
    }

    public static int RequiredXP
    {
        get; set;
    }

    public static int Stamina
    {
        get; set;
    }

    public static int Strength
    {
        get; set;
    }

    public static int Agility
    {
        get; set;
    }

    public static int Intellect
    {
        get; set;
    }

    public static int Mana
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

    public static int ShadowResist
    {
        get; set;
    }

    public static int FrostResist
    {
        get; set;
    }

    public static int NatureResist
    {
        get; set;
    }

    public static int HolyResist
    {
        get; set;
    }

    public static int ArcaneResist
    {
        get; set;
    }

    public static int FireResist
    {
        get; set;
    }

    public static int Gold
    {
        get; set;
    }
}



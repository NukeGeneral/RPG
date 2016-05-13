using UnityEngine;
using System.Collections;

public class LoadGame : MonoBehaviour {

    public static void LoadGameInfo()
    {
        PlayerInfo.PlayerName = PlayerPrefs.GetString("PLAYER_NAME");
        PlayerInfo.PlayerLevel = PlayerPrefs.GetInt("PLAYER_LEVEL");
        //PlayerInfo.PlayerClass = PlayerPrefs.GetString("PLAYER_CLASS");
        //PlayerInfo.PlayerRace = PlayerPrefs.GetString("PLAYER_RACE");
        PlayerInfo.Stamina = PlayerPrefs.GetInt("STAMINA");
        PlayerInfo.Strength = PlayerPrefs.GetInt("STRENGTH");
        PlayerInfo.Intellect = PlayerPrefs.GetInt("INTELLECT");
        PlayerInfo.Agility = PlayerPrefs.GetInt("AGILITY");
        PlayerInfo.Mana = PlayerPrefs.GetInt("MANA");
        PlayerInfo.Speed = PlayerPrefs.GetInt("SPEED");
        PlayerInfo.Health = PlayerPrefs.GetInt("HEALTH");
        PlayerInfo.ShadowResist = PlayerPrefs.GetInt("SHADOW_RESIST");
        PlayerInfo.HolyResist = PlayerPrefs.GetInt("HOLY_RESIST");
        PlayerInfo.NatureResist = PlayerPrefs.GetInt("NATURE_RESIST");
        PlayerInfo.FireResist = PlayerPrefs.GetInt("FIRE_RESIST");
        PlayerInfo.FrostResist = PlayerPrefs.GetInt("FROST_RESIST");
        PlayerInfo.ArcaneResist = PlayerPrefs.GetInt("ARCANE_RESIST");
        PlayerInfo.Gold = PlayerPrefs.GetInt("GOLD");

    }
}

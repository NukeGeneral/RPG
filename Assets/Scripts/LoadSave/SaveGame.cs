using UnityEngine;
using System.Collections;

public class SaveGame : MonoBehaviour {

	public static void SaveGameInfo()
    {
        PlayerPrefs.SetString("PLAYER_NAME", PlayerInfo.PlayerName);
        PlayerPrefs.SetInt("PLAYER_LEVEL", PlayerInfo.PlayerLevel);
        PlayerPrefs.SetString("PLAYER_CLASS", PlayerInfo.PlayerClass.ToString());
        PlayerPrefs.SetString("PLAYER_RACE", PlayerInfo.PlayerRace.ToString());
        PlayerPrefs.SetInt("STAMINA", PlayerInfo.Stamina);
        PlayerPrefs.SetInt("STRENGTH", PlayerInfo.Strength);
        PlayerPrefs.SetInt("INTELLECT", PlayerInfo.Intellect);
        PlayerPrefs.SetInt("AGILITY", PlayerInfo.Agility);
        PlayerPrefs.SetInt("MANA", PlayerInfo.Mana);
        PlayerPrefs.SetInt("SPEED", PlayerInfo.Speed);
        PlayerPrefs.SetInt("HEALTH", PlayerInfo.Health);
        PlayerPrefs.SetInt("SHADOW_RESIST", PlayerInfo.ShadowResist);
        PlayerPrefs.SetInt("HOLY_RESIST", PlayerInfo.HolyResist);
        PlayerPrefs.SetInt("NATURE_RESIST", PlayerInfo.NatureResist);
        PlayerPrefs.SetInt("FIRE_RESIST", PlayerInfo.FireResist);
        PlayerPrefs.SetInt("FROST_RESIST", PlayerInfo.FrostResist);
        PlayerPrefs.SetInt("ARCANE_RESIST", PlayerInfo.ArcaneResist);
        PlayerPrefs.SetInt("GOLD", PlayerInfo.Gold);
    }
}

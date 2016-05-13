using UnityEngine;
using System.Collections;

public class CommonMobCreate : MonoBehaviour {

    private MobSpreadsheet newMob;
    private BaseMob mobData;

	// Use this for initialization
	void Start () {
        newMob = new MobSpreadsheet();
        newMob.MobType = new BaseMeleeMob();
        newMob.AffixChoose = MobSpreadsheet.Affixes.Common;
        newMob.MobName = newMob.AffixChoose.ToString() + MobSpreadsheet.Affixes.Common.ToString();
        newMob.MobAffixDesc = newMob.MobAffixDesc;
        newMob.Mana = mobData.Mana * PlayerInfo.PlayerLevel / 10;
        newMob.Health = mobData.Health * PlayerInfo.PlayerLevel / 2;
        newMob.MobLevel = PlayerInfo.PlayerLevel;
        newMob.Agility = mobData.Agility * PlayerInfo.PlayerLevel;
        newMob.Intellect = mobData.Intellect * PlayerInfo.PlayerLevel;
        newMob.Strength = mobData.Strength * PlayerInfo.PlayerLevel;
        newMob.Stamina = mobData.Stamina * PlayerInfo.PlayerLevel;
        newMob.ArcaneResist = mobData.ArcaneResist;
        newMob.FireResist = mobData.FireResist;
        newMob.FrostResist = mobData.FrostResist;
        newMob.HolyResist = mobData.HolyResist;
        newMob.NatureResist = mobData.NatureResist;
        newMob.ShadowResist = mobData.ShadowResist;
        print(newMob.MobName);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

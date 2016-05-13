using UnityEngine;
using System.Collections;

public class BattleCalculations : MonoBehaviour {

    private BaseMob mobStats;
    private int abilityPower;

	public void AbilityCalculations(BaseAbility usedAbility)
    {
        
    }

    public void MobStatAdjustment(int level)
    {
        mobStats.MobLevel = Random.Range(level - 1, level + 1);
        mobStats.Stamina += level * 2;
        mobStats.Strength += level * 2;
        mobStats.Agility += level * 2;
        mobStats.Intellect += level * 2;
    }
}

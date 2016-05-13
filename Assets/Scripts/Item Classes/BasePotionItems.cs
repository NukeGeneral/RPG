using UnityEngine;
using System.Collections;

public class BasePotionItems : BaseItemStats {
    // Six type potion

	public enum PotionTypes {Health,Mana,Strength,Intellect,Agility,Speed}


    public PotionTypes PotionType
    {
        get; set;
    }
}

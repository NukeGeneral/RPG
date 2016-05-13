using UnityEngine;
using System.Collections;

public class ExperienceSystem {

    private PlayerSpreadsheet myCharacter;
    private int[] requiredXP = new int[50];

    public void IncreaseXP(int mobXP)
    {
        myCharacter.CurrentXP += mobXP;
        IsLevelledUp(myCharacter.CurrentXP);      
    }

    void IsLevelledUp(int currentXP)
    {
        if(myCharacter.CurrentXP > myCharacter.RequiredXP && myCharacter.PlayerLevel < 51)
        {
            myCharacter.PlayerLevel++;
            myCharacter.CurrentXP -= myCharacter.RequiredXP;
            myCharacter.RequiredXP = RequiredXPFormula(myCharacter.PlayerLevel);
            if(myCharacter.PlayerClass.ToString() == "BaseWarrior" || myCharacter.PlayerClass.ToString() == "BaseTemplar")
            {
                myCharacter.Strength += 3;
                myCharacter.Agility += 1;
                myCharacter.Intellect += 1;
                myCharacter.Stamina += 7;
            }

            else if (myCharacter.PlayerClass.ToString() == "BaseHunter" || myCharacter.PlayerClass.ToString() == "BaseMonk")
            {
                myCharacter.Strength += 1;
                myCharacter.Agility += 3;
                myCharacter.Intellect += 1;
                myCharacter.Stamina += 7;
            }

            else if (myCharacter.PlayerClass.ToString() == "BasePriest" || myCharacter.PlayerClass.ToString() == "BaseWizard")
            {
                myCharacter.Strength += 1;
                myCharacter.Agility += 1;
                myCharacter.Intellect += 3;
                myCharacter.Stamina += 7;
            }
        }
    }

    public int RequiredXPFormula(int level)
    {
        requiredXP[0] = 477;
        if (level <= 9)
        {
            requiredXP[level] = (int)(requiredXP[level - 1] * 1.1f);
        }

        else
        {
            requiredXP[level] = (int)(requiredXP[level - 1] * 1.02f);
        }

        return requiredXP[level];
    }
}

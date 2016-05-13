using UnityEngine;
using System.Collections;

public class CreateNewPotion : MonoBehaviour {

    private BasePotionItems newPotion;
    private PlayerSpreadsheet myCharacter;

    public int RandomValueAssigner()
    {
        return Random.Range(1, 257);
    }

    public void CreatePotion()
    {
        newPotion = new BasePotionItems();
        newPotion.ItemName = "Potion" + RandomValueAssigner().ToString();
        newPotion.ItemDesc = "New type of potion " + RandomValueAssigner().ToString();
        int potionRoller = Random.Range(1, 4);
        if (myCharacter.PlayerClass.ToString() == "BaseWarrior" || myCharacter.PlayerClass.ToString() == "BaseTemplar")       
        {
            if(potionRoller == 1)
            {
                newPotion.PotionType = BasePotionItems.PotionTypes.Strength;
                newPotion.Strength = 0;
            }
            else if(potionRoller == 2)
            {
                newPotion.PotionType = BasePotionItems.PotionTypes.Health;
                newPotion.Health = myCharacter.Health * 6 / 10;
            }

            else if(potionRoller == 3)
            {
                newPotion.PotionType = BasePotionItems.PotionTypes.Mana;
                newPotion.Mana = myCharacter.Mana * 6 / 10;
            }
            else
            {
                newPotion.PotionType = BasePotionItems.PotionTypes.Speed;
                newPotion.Speed = 170;
            }

        }

        else if(myCharacter.PlayerClass.ToString() == "BaseMonk" || myCharacter.PlayerClass.ToString() == "BaseHunter")
        {
            if (potionRoller == 1)
            {
                newPotion.PotionType = BasePotionItems.PotionTypes.Agility;
                newPotion.Agility = 0;
            }
            else if (potionRoller == 2)
            {
                newPotion.PotionType = BasePotionItems.PotionTypes.Health;
                newPotion.Health = myCharacter.Health * 6 / 10;
            }

            else if (potionRoller == 3)
            {
                newPotion.PotionType = BasePotionItems.PotionTypes.Mana;
                newPotion.Mana = myCharacter.Mana * 6 / 10;
            }
            else
            {
                newPotion.PotionType = BasePotionItems.PotionTypes.Speed;
                newPotion.Speed = 170;
            }
        }
        
        else
        {
            if (potionRoller == 1)
            {
                newPotion.PotionType = BasePotionItems.PotionTypes.Intellect;
                newPotion.Intellect = 0;
            }
            else if (potionRoller == 2)
            {
                newPotion.PotionType = BasePotionItems.PotionTypes.Health;
                newPotion.Health = myCharacter.Health * 6 / 10;
            }

            else if (potionRoller == 3)
            {
                newPotion.PotionType = BasePotionItems.PotionTypes.Mana;
                newPotion.Mana = myCharacter.Mana * 6 / 10;
            }

            else
            {
                newPotion.PotionType = BasePotionItems.PotionTypes.Speed;
                newPotion.Speed = 170;
            }
        }       
    }
}

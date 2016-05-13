using UnityEngine;
using System.Collections;

public class CreateNewArmor : MonoBehaviour {

    private BaseEquipmentItems newArmor;
    private PlayerSpreadsheet myCharacter;
    private int randomGen;
    private CreateArtifacts createArtifact;

    public int CreateQuality()
    {
        return Random.Range(1, 5);
    }

    public void CreateArmor()
    {
        randomGen = RandomValueAssigner();
        newArmor = new BaseEquipmentItems();
        newArmor.ItemName = "Armor" + randomGen.ToString();
        newArmor.ItemDesc = "Number of armor is " + randomGen.ToString();
        ArmorWeightType();
        ArmorType();
        newArmor.Stamina = 0;
        newArmor.Strength = 0;
        newArmor.Agility = 0;
        newArmor.Intellect = 0;
        newArmor.Resist = 0;
        ChooseResist();

        if (CreateQuality() == 1)
        {
            //TO DO: MIN-MAX DAMAGE AND ATTACK-SPEED
        }

        else if (CreateQuality() == 2)
        {
            //TO DO : MIN-MAX DAMAGE AND MAIN STAT
        }

        else if (CreateQuality() == 3)
        {
            //TO DO : MIN-MAX DAMAGE,TWO RANDOM PRIMARY STAT
        }

        else if (CreateQuality() == 4)
        {
            //TO DO : MIN-MAX DAMAGE,TWO RANDOM PRIMARY STAT AND ELEMENTAL DAMAGE
        }

        else
        {
            //TO DO : ARTIFACT WEAPON,ALL UNIQUE SPECS WITH SPECIAL ABILITY
            createArtifact = new CreateArtifacts();
            createArtifact.ArtifactWeapon();
        }

    }

    public void ChooseResist()
    {
        int chooseResist = Random.Range(1, 6);
        {
            if (chooseResist == 1)
            {
                newArmor.ResistType = BaseEquipmentItems.ResistTypes.Arcane_Resist;
            }

            else if (chooseResist == 2)
            {
                newArmor.ResistType = BaseEquipmentItems.ResistTypes.Fire_Resist;
            }

            else if (chooseResist == 3)
            {
                newArmor.ResistType = BaseEquipmentItems.ResistTypes.Frost_Resist;
            }

            else if (chooseResist == 4)
            {
                newArmor.ResistType = BaseEquipmentItems.ResistTypes.Holy_Resist;
            }

            else if (chooseResist == 5)
            {
                newArmor.ResistType = BaseEquipmentItems.ResistTypes.Poison_Resist;
            }

            else if (chooseResist == 6)
            {
                newArmor.ResistType = BaseEquipmentItems.ResistTypes.Shadow_Resist;
            }
        }
    }

    public int RandomValueAssigner()
    {
        return Random.Range(1, 257);
    }

    public void ArmorWeightType()
    {
        if (myCharacter.PlayerClass.ToString() == "BaseWarrior" || myCharacter.PlayerClass.ToString() == "BaseTemplar")
        {
            newArmor.ArmorWeightType = BaseEquipmentItems.ArmorWeightTypes.Mail;
        }

        else if(myCharacter.PlayerClass.ToString() == "BaseMonk" || myCharacter.PlayerClass.ToString() == "BaseHunter")
        {
            newArmor.ArmorWeightType = BaseEquipmentItems.ArmorWeightTypes.Leather;
        }
        else
        {
            newArmor.ArmorWeightType = BaseEquipmentItems.ArmorWeightTypes.Cloth;
        }
    }

    public void ArmorType()
    {
        int armorTypeGen = Random.Range(1, 10);
        if (armorTypeGen == 1)
        {
            newArmor.ArmorType = BaseEquipmentItems.ArmorTypes.Belt;
            newArmor.ItemID = 11000 + randomGen;
        }

        else if (armorTypeGen == 2)
        {
            newArmor.ArmorType = BaseEquipmentItems.ArmorTypes.Chest_Armor;
            newArmor.ItemID = 12000 + randomGen;
        }

        else if (armorTypeGen == 3)
        {
            newArmor.ArmorType = BaseEquipmentItems.ArmorTypes.Feet;
            newArmor.ItemID = 13000 + randomGen;
        }

        else if (armorTypeGen == 4)
        {
            newArmor.ArmorType = BaseEquipmentItems.ArmorTypes.Gloves;
            newArmor.ItemID = 14000 + randomGen;
        }

        else if (armorTypeGen == 5)
        {
            newArmor.ArmorType = BaseEquipmentItems.ArmorTypes.Head;
            newArmor.ItemID = 15000 + randomGen;
        }

        else if (armorTypeGen == 6)
        {
            newArmor.ArmorType = BaseEquipmentItems.ArmorTypes.Legs;
            newArmor.ItemID = 16000 + randomGen;
        }

        else if (armorTypeGen == 7)
        {
            newArmor.ArmorType = BaseEquipmentItems.ArmorTypes.Necklace;
            newArmor.ItemID = 17000 + randomGen;
        }

        else if (armorTypeGen == 8)
        {
            newArmor.ArmorType = BaseEquipmentItems.ArmorTypes.Ring;
            newArmor.ItemID = 18000 + randomGen;
        }

        else if (armorTypeGen == 9)
        {
            newArmor.ArmorType = BaseEquipmentItems.ArmorTypes.Shoulders;
            newArmor.ItemID = 19000 + randomGen;
        }

        else if (armorTypeGen == 10)
        {
            newArmor.ArmorType = BaseEquipmentItems.ArmorTypes.Waist;
            newArmor.ItemID = 20000 + randomGen;
        }
    }
}
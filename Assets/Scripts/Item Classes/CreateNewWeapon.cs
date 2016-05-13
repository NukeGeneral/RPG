using UnityEngine;
using System.Collections;

public class CreateNewWeapon : MonoBehaviour {
    // 1 Hand Sword,Shield and 2 Hand Axe for Barbarian,1 Hand Sword,Shield and Relic for Templar,Wand, Orb and Staff for Wizard,Bow and Quiver for Hunter,Wand,Relic and Staff for Cleric,Fist Weapons,1 Hand Sword and 2 Hand Axe for Monks
    private BaseWeaponItems newWeapon;
    private PlayerSpreadsheet myCharacter;
    private CreateArtifacts createArtifact;
    private int randomGen;

    public int CreateQuality()
    {
        return Random.Range(1, 100); // Common,Uncommon,Rare,Unique,Artifact
    }

    public void CreateWeapon()
    {
        if(CreateQuality() <= 99)
        {
            randomGen = RandomValueAssigner();
            newWeapon = new BaseWeaponItems();
            newWeapon.ItemName = "Weapon" + randomGen.ToString();
            newWeapon.ItemDesc = "Number of weapon is " + randomGen.ToString();
            WeaponType();

            if (CreateQuality() >= 1 && CreateQuality() <= 50)
            {
                newWeapon.MinDMG = 1 * myCharacter.PlayerLevel;
                newWeapon.MaxDMG = 3 * myCharacter.PlayerLevel;
            }

            else if (CreateQuality() >= 51 && CreateQuality() <= 80)
            {
                newWeapon.MinDMG = 1 * myCharacter.PlayerLevel;
                newWeapon.MaxDMG = 3 * myCharacter.PlayerLevel;
                if(myCharacter.PlayerClass.ToString() == "BaseWarrior" || myCharacter.PlayerClass.ToString() == "BaseTemplar")
                {
                    if(Random.Range(1,100) <= 80)
                    {
                        newWeapon.Strength = (int)2 * myCharacter.PlayerLevel / 3;
                    }

                    else
                    {
                        int temp = Random.Range(1, 100);
                        if(temp <= 33)
                        {
                            newWeapon.Agility = (int)2 * myCharacter.PlayerLevel / 3;
                        }

                        else if(temp >= 34 && temp <= 66)
                        {
                            newWeapon.Intellect = (int)2 * myCharacter.PlayerLevel / 3;
                        }

                        else if(temp >= 67 && temp <= 100)
                        {
                            newWeapon.Stamina = (int)2 * myCharacter.PlayerLevel / 3;
                        }
                    }
                }
               else if (myCharacter.PlayerClass.ToString() == "BaseHunter" || myCharacter.PlayerClass.ToString() == "BaseMonk")
                {
                    if (Random.Range(1, 100) <= 80)
                    {
                        newWeapon.Agility = (int)2 * myCharacter.PlayerLevel / 3;
                    }

                    else
                    {
                        int temp = Random.Range(1, 100);
                        if (temp <= 33)
                        {
                            newWeapon.Strength = (int)2 * myCharacter.PlayerLevel / 3;
                        }

                        else if (temp >= 34 && temp <= 66)
                        {
                            newWeapon.Intellect = (int)2 * myCharacter.PlayerLevel / 3;
                        }

                        else if (temp >= 67 && temp <= 100)
                        {
                            newWeapon.Stamina = (int)2 * myCharacter.PlayerLevel / 3;
                        }
                    }
                }

                else
                {
                    if (Random.Range(1, 100) <= 80)
                    {
                        newWeapon.Intellect = (int)2 * myCharacter.PlayerLevel / 3;
                    }

                    else
                    {
                        int temp = Random.Range(1, 100);
                        if (temp <= 33)
                        {
                            newWeapon.Agility = (int)2 * myCharacter.PlayerLevel / 3;
                        }

                        else if (temp >= 34 && temp <= 66)
                        {
                            newWeapon.Strength = (int)2 * myCharacter.PlayerLevel / 3;
                        }

                        else if (temp >= 67 && temp <= 100)
                        {
                            newWeapon.Stamina = (int)2 * myCharacter.PlayerLevel / 3;
                        }
                    }
                }
            }

            else if (CreateQuality() >= 81 && CreateQuality() <= 95)
            {
                newWeapon.MinDMG = 1 * myCharacter.PlayerLevel;
                newWeapon.MaxDMG = 3 * myCharacter.PlayerLevel;
                if (myCharacter.PlayerClass.ToString() == "BaseWarrior" || myCharacter.PlayerClass.ToString() == "BaseTemplar")
                {
                    newWeapon.Strength = (int)2 * myCharacter.PlayerLevel / 3;

                        int temp = Random.Range(1, 100);
                        if (temp <= 33)
                        {
                            newWeapon.Agility = (int)2 * myCharacter.PlayerLevel / 3;
                        }

                        else if (temp >= 34 && temp <= 66)
                        {
                            newWeapon.Intellect = (int)2 * myCharacter.PlayerLevel / 3;
                        }

                        else if (temp >= 67 && temp <= 100)
                        {
                            newWeapon.Stamina = (int)2 * myCharacter.PlayerLevel / 3;
                        }

                }
                else if (myCharacter.PlayerClass.ToString() == "BaseHunter" || myCharacter.PlayerClass.ToString() == "BaseMonk")
                {
                    newWeapon.Agility = (int)2 * myCharacter.PlayerLevel / 3;
                        int temp = Random.Range(1, 100);
                        if (temp <= 33)
                        {
                            newWeapon.Strength = (int)2 * myCharacter.PlayerLevel / 3;
                        }

                        else if (temp >= 34 && temp <= 66)
                        {
                            newWeapon.Intellect = (int)2 * myCharacter.PlayerLevel / 3;
                        }

                        else if (temp >= 67 && temp <= 100)
                        {
                            newWeapon.Stamina = (int)2 * myCharacter.PlayerLevel / 3;
                        }
                }

                else
                {
                    newWeapon.Intellect = (int)2 * myCharacter.PlayerLevel / 3;
                        int temp = Random.Range(1, 100);
                        if (temp <= 33)
                        {
                            newWeapon.Agility = (int)2 * myCharacter.PlayerLevel / 3;
                        }

                        else if (temp >= 34 && temp <= 66)
                        {
                            newWeapon.Strength = (int)2 * myCharacter.PlayerLevel / 3;
                        }

                        else if (temp >= 67 && temp <= 100)
                        {
                            newWeapon.Stamina = (int)2 * myCharacter.PlayerLevel / 3;
                        }
                }
            }

            else if (CreateQuality() >= 96 && CreateQuality() <= 99)
            {
                newWeapon.MinDMG = 1 * myCharacter.PlayerLevel;
                newWeapon.MaxDMG = 3 * myCharacter.PlayerLevel;
                if (myCharacter.PlayerClass.ToString() == "BaseWarrior" || myCharacter.PlayerClass.ToString() == "BaseTemplar")
                {
                    newWeapon.Strength = (int)2 * myCharacter.PlayerLevel / 3;

                    int temp = Random.Range(1, 100);
                    if (temp <= 33)
                    {
                        newWeapon.Agility = (int)2 * myCharacter.PlayerLevel / 3;
                    }

                    else if (temp >= 34 && temp <= 66)
                    {
                        newWeapon.Intellect = (int)2 * myCharacter.PlayerLevel / 3;
                    }

                    else if (temp >= 67 && temp <= 100)
                    {
                        newWeapon.Stamina = (int)2 * myCharacter.PlayerLevel / 3;
                    }

                }
                else if (myCharacter.PlayerClass.ToString() == "BaseHunter" || myCharacter.PlayerClass.ToString() == "BaseMonk")
                {
                    newWeapon.Agility = (int)2 * myCharacter.PlayerLevel / 3;
                    int temp = Random.Range(1, 100);
                    if (temp <= 33)
                    {
                        newWeapon.Strength = (int)2 * myCharacter.PlayerLevel / 3;
                    }

                    else if (temp >= 34 && temp <= 66)
                    {
                        newWeapon.Intellect = (int)2 * myCharacter.PlayerLevel / 3;
                    }

                    else if (temp >= 67 && temp <= 100)
                    {
                        newWeapon.Stamina = (int)2 * myCharacter.PlayerLevel / 3;
                    }
                }

                else
                {
                    newWeapon.Intellect = (int)2 * myCharacter.PlayerLevel / 3;
                    int temp = Random.Range(1, 100);
                    if (temp <= 33)
                    {
                        newWeapon.Agility = (int)2 * myCharacter.PlayerLevel / 3;
                    }

                    else if (temp >= 34 && temp <= 66)
                    {
                        newWeapon.Strength = (int)2 * myCharacter.PlayerLevel / 3;
                    }

                    else if (temp >= 67 && temp <= 100)
                    {
                        newWeapon.Stamina = (int)2 * myCharacter.PlayerLevel / 3;
                    }
                }
                ChooseElement();
            }
        }

        else
        {
            // TO DO : ARTIFACT WEAPON,ALL UNIQUE SPECS WITH SPECIAL ABILITY
            createArtifact = new CreateArtifacts();
            createArtifact.ArtifactWeapon();
        }
    }

    public void ChooseElement()
    {
        int chooseResist = Random.Range(1, 6);
        {
            if (chooseResist == 1)
            {
                newWeapon.ElementType = BaseWeaponItems.ElementTypes.Arcane;
            }

            else if (chooseResist == 2)
            {
                newWeapon.ElementType = BaseWeaponItems.ElementTypes.Fire;
            }

            else if (chooseResist == 3)
            {
                newWeapon.ElementType = BaseWeaponItems.ElementTypes.Frost;
            }

            else if (chooseResist == 4)
            {
                newWeapon.ElementType = BaseWeaponItems.ElementTypes.Holy;
            }

            else if (chooseResist == 5)
            {
                newWeapon.ElementType = BaseWeaponItems.ElementTypes.Nature;
            }

            else if (chooseResist == 6)
            {
                newWeapon.ElementType = BaseWeaponItems.ElementTypes.Shadow;
            }
        }
    }

    public int RandomValueAssigner()
    {
        return Random.Range(1, 257);
    }

    public void WeaponType()
    {
        if(myCharacter.PlayerClass.ToString() == "BaseWarrior")
        {
            int temp = Random.Range(1, 3);
            if(temp == 1)
            {
                newWeapon.WeaponType = BaseWeaponItems.WeaponTypes.OneHand_Sword;
                newWeapon.ItemID = 1000 + randomGen;
                newWeapon.AttackSpeed = 2.60f;
            }
            else if(temp == 2)
            {
                newWeapon.WeaponType = BaseWeaponItems.WeaponTypes.TwoHand_Axe;
                newWeapon.ItemID = 2000 + randomGen;
                newWeapon.AttackSpeed = 3.60f;
            }

            else if (temp == 3)
            {
                newWeapon.WeaponType = BaseWeaponItems.WeaponTypes.Shield;
                newWeapon.ItemID = 3000 + randomGen;
                newWeapon.AttackSpeed = 3.30f;
            }
            
        }

        else if (myCharacter.PlayerClass.ToString() == "BaseHunter")
        {
            int temp = Random.Range(1, 2);
            if(temp == 1)
            {
                newWeapon.WeaponType = BaseWeaponItems.WeaponTypes.Bow;
                newWeapon.ItemID = 4000 + randomGen;
                newWeapon.AttackSpeed = 3.30f;
            }

            else if(temp == 2)
            {
                newWeapon.WeaponType = BaseWeaponItems.WeaponTypes.Quiver;
                newWeapon.ItemID = 5000 + randomGen;
                newWeapon.AttackSpeed = 1.80f; 
            }

        }

        else if(myCharacter.PlayerClass.ToString() == "BaseTemplar")
        {
            int temp = Random.Range(1, 3);
            if (temp == 1)
            {
                newWeapon.WeaponType = BaseWeaponItems.WeaponTypes.OneHand_Sword;
                newWeapon.ItemID = 1000 + randomGen;
                newWeapon.AttackSpeed = 2.60f;
            }

            else if (temp == 2)
            {
                newWeapon.WeaponType = BaseWeaponItems.WeaponTypes.Relic;
                newWeapon.ItemID = 6000 + randomGen;
                newWeapon.AttackSpeed = 1.80f;
            }

            else if (temp == 3)
            {
                newWeapon.WeaponType = BaseWeaponItems.WeaponTypes.Shield;
                newWeapon.ItemID = 3000 + randomGen;
                newWeapon.AttackSpeed = 3.30f;
            }

        }

        else if(myCharacter.PlayerClass.ToString() == "BasePriest")
        {
            int temp = Random.Range(1, 3);
            if (temp == 1)
            {
                newWeapon.WeaponType = BaseWeaponItems.WeaponTypes.Wand;
                newWeapon.ItemID = 7000 + randomGen;
                newWeapon.AttackSpeed = 1.75f;
            }

            else if (temp == 2)
            {
                newWeapon.WeaponType = BaseWeaponItems.WeaponTypes.Relic;
                newWeapon.ItemID = 6000 + randomGen;
                newWeapon.AttackSpeed = 1.80f;
            }

            else if (temp == 3)
            {
                newWeapon.WeaponType = BaseWeaponItems.WeaponTypes.Staff;
                newWeapon.ItemID = 8000 + randomGen;
                newWeapon.AttackSpeed = 3.00f;
            }

        }

        else if(myCharacter.PlayerClass.ToString() == "BaseMonk")
        {
            int temp = Random.Range(1, 3);
            if (temp == 1)
            {
                newWeapon.WeaponType = BaseWeaponItems.WeaponTypes.OneHand_Sword;
                newWeapon.ItemID = 1000 + randomGen;
                newWeapon.AttackSpeed = 2.60f;
            }

            else if (temp == 2)
            {
                newWeapon.WeaponType = BaseWeaponItems.WeaponTypes.TwoHand_Axe;
                newWeapon.ItemID = 2000 + randomGen;
                newWeapon.AttackSpeed = 3.60f;
            }

            else if (temp == 3)
            {
                newWeapon.WeaponType = BaseWeaponItems.WeaponTypes.Fist_Weapon;
                newWeapon.ItemID = 9000 + randomGen;
                newWeapon.AttackSpeed = 2.25f;
            }

        }

        else if(myCharacter.PlayerClass.ToString() == "BaseWizard")
        {
            int temp = Random.Range(1, 3);
            if (temp == 1)
            {
                newWeapon.WeaponType = BaseWeaponItems.WeaponTypes.Wand;
                newWeapon.ItemID = 7000 + randomGen;
                newWeapon.AttackSpeed = 1.75f;
            }

            else if (temp == 2)
            {
                newWeapon.WeaponType = BaseWeaponItems.WeaponTypes.Orb;
                newWeapon.ItemID = 10000 + randomGen;
                newWeapon.AttackSpeed = 1.80f;
            }

            else if (temp == 3)
            {
                newWeapon.WeaponType = BaseWeaponItems.WeaponTypes.Staff;
                newWeapon.ItemID = 8000 + randomGen;
                newWeapon.AttackSpeed = 3.20f;
            }

        }
    }
}

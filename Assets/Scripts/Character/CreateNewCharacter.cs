using UnityEngine;
using UnityEngine.UI;
using System.Collections;

//TO DO: ADD SECONDARY PERKS AND REWORK ON CODE OF CLASS/RACE CHOOSE
public class CreateNewCharacter : MonoBehaviour {

    private bool isWarrior,isWizard,isHunter,isMonk,isTemplar,isPriest,isHuman,isElf = false;
    private PlayerSpreadsheet newCharacter;
    private InputField characterNameField;
    private ExperienceSystem xpSystem;

    void Start()
    {
        newCharacter = new PlayerSpreadsheet();
        characterNameField = FindObjectOfType<InputField>();
    }

    public void IsWarrior()
    {
        isWarrior = true;
    }

    public void IsWizard()
    {
        isWizard = true;
    }

    public void IsHunter()
    {
        isHunter = true;
    }

    public void IsMonk()
    {
        isMonk = true;
    }

    public void IsTemplar()
    {
        isTemplar = true;
    }

    public void IsPriest()
    {
        isPriest = true;
    }

    public void IsHuman()
    {
        isHuman = true;
    }

    public void IsElf()
    {
        isElf = true;
    }

    public void ChooseClass()
    {
        if (isWarrior)
        {
            newCharacter.PlayerClass = new BaseWarrior();
            ChooseRace();
        }

        else if (isHunter)
        {
            newCharacter.PlayerClass = new BaseHunter();
            ChooseRace();
        }

        else if (isMonk)
        {
            newCharacter.PlayerClass = new BaseMonk();
            ChooseRace();
        }

        else if (isTemplar)
        {
            newCharacter.PlayerClass = new BaseTemplar();
            ChooseRace();
        }

        else if (isPriest)
        {
            newCharacter.PlayerClass = new BasePriest();
            ChooseRace();
        }

        else if (isWizard)
        {
            newCharacter.PlayerClass = new BaseWizard();
            ChooseRace();
        }
        newCharacter.PlayerLevel = 1;
        newCharacter.CurrentXP = 0;
        newCharacter.PlayerName = characterNameField.text;
        newCharacter.Stamina = newCharacter.PlayerClass.Stamina;
        newCharacter.Strength = newCharacter.PlayerClass.Strength;
        newCharacter.Agility = newCharacter.PlayerClass.Agility;
        newCharacter.Intellect = newCharacter.PlayerClass.Intellect;
        newCharacter.Mana = newCharacter.PlayerClass.Mana;
        newCharacter.Health = newCharacter.PlayerClass.Health;
        newCharacter.Speed = newCharacter.PlayerClass.Speed;
        newCharacter.ArcaneResist = newCharacter.PlayerRace.ArcaneResist;
        newCharacter.FireResist = newCharacter.PlayerRace.FireResist;
        newCharacter.FrostResist = newCharacter.PlayerRace.FrostResist;
        newCharacter.HolyResist = newCharacter.PlayerRace.HolyResist;
        newCharacter.NatureResist = newCharacter.PlayerRace.NatureResist;
        newCharacter.ShadowResist = newCharacter.PlayerRace.ShadowResist;
        newCharacter.Gold = 1;
        newCharacter.RequiredXP = xpSystem.RequiredXPFormula(newCharacter.PlayerLevel);
        PassPlayerInfo(newCharacter);
        SaveGame.SaveGameInfo();
        Debug.Log(newCharacter.RequiredXP);
        Debug.Log("Character agility is " + newCharacter.PlayerClass.Strength);
        Debug.Log("Character name is " + newCharacter.PlayerName);
        Debug.Log("Character resist is " + newCharacter.PlayerRace.FireResist);
        Debug.Log("Character class is " + newCharacter.PlayerClass);
    }

    public void ChooseRace()
    {
        if (isHuman)
        {
            newCharacter.PlayerRace = new BaseHuman();
        }
        else if (isElf)
        {
            newCharacter.PlayerRace = new BaseElf();
        }
    }

    void PassPlayerInfo(PlayerSpreadsheet copy)
    {
        PlayerInfo.PlayerName = copy.PlayerName;
        PlayerInfo.PlayerLevel = copy.PlayerLevel;
        PlayerInfo.PlayerClass = copy.PlayerClass;
        PlayerInfo.PlayerRace = copy.PlayerRace;
        PlayerInfo.Stamina = copy.Stamina;
        PlayerInfo.Strength = copy.Strength;
        PlayerInfo.Intellect = copy.Intellect;
        PlayerInfo.Agility = copy.Agility;
        PlayerInfo.Mana = copy.Mana;
        PlayerInfo.Speed = copy.Speed;
        PlayerInfo.Health = copy.Health;
        PlayerInfo.ShadowResist = copy.ShadowResist;
        PlayerInfo.HolyResist = copy.HolyResist;
        PlayerInfo.NatureResist = copy.NatureResist;
        PlayerInfo.FireResist = copy.FireResist;
        PlayerInfo.FrostResist = copy.FrostResist;
        PlayerInfo.ArcaneResist = copy.ArcaneResist;
        PlayerInfo.RequiredXP = copy.RequiredXP;
        PlayerInfo.CurrentXP = copy.RequiredXP;
    }
}
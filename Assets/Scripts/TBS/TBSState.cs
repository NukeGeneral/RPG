using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TBSState : MonoBehaviour {

    public enum States {Initialize,Player_Choice,Enemy_Choice,Lose,Win }
    private int mobXP = 50; // TO DO:Add xp info to mob instead of here
    private ExperienceSystem xp;
    private BattleCalculations mobAdjustment;
    private PlayerSpreadsheet myCharacter;
    private BaseAbility usedAbility;
    private BaseMob newMob;
    public bool cleaveFlag, autoFlag = false;

    private States currentState;

	// Use this for initialization
	void Start () {
        currentState = States.Initialize;
	}

    // Update is called once per frame
    void Update()
    {
        switch (currentState)
        {
            case (States.Initialize):

                break;

            case (States.Player_Choice):
                break;

            case (States.Enemy_Choice):
                break;

            case (States.Lose):
                break;

            case (States.Win):
                xp.IncreaseXP(mobXP);
                break;
        }

        Debug.Log(currentState);
    }

    public void CleaveFlag()
    {
        cleaveFlag = true;
    }

    public void AutoAttackFlag()
    {
        autoFlag = true;
    }

    void OnButtonClickEvent()
    {
        if (cleaveFlag)
        {
            usedAbility = new WarriorCleave();
        }

        else
        {
            usedAbility = new AutoAttack();
        }
    }
}

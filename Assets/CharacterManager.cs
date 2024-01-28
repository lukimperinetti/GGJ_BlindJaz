using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CharacterManager : MonoBehaviour
{
    private int fatigue = 0;
    private int reputation = 0;
    private int reputationLevel = 0;
    private int money = 0;
    [SerializeField] private ReputationLvlText reputationLvlText;
    [SerializeField] private PopUpMessageReputation popUpMessageReputation;
    [SerializeField] private PopUpMessageFatigue popUpMessageFatigue;
    [SerializeField] private PopUpMessageMoney popUpMessageMoney;

    public void Update()
    {
        if (fatigue > 100)
        {
            fatigue = 100;
        }
        if (reputation >= 100 * (Math.Pow(2, reputationLevel)))
        {
            reputationLevel++;
            reputation = 0;
            reputationLvlText.setLvl(reputationLevel);
        }
    }

    public void addFatigue(int fatigue)
    {
        this.fatigue += fatigue;
        popUpMessageFatigue.showMessage("-" + fatigue, 2);
    }
    public void rest()
    {
        popUpMessageFatigue.showMessage("+" + fatigue, 2);
        fatigue = 0;
    }

    public void addReputation(int reputation)
    {
        this.reputation += reputation;
        popUpMessageReputation.showMessage("+" + reputation, 2);
    }

    public void addMoney(int money)
    {
        this.money += money;
        popUpMessageMoney.showMessage("+" + money, 2);
    }

    public int getFatigue()
    {
        return fatigue;
    }
    public int getReputation()
    {
        return reputation;
    }
    public int getReputationLevel()
    {
        return reputationLevel;
    }
    public int getMoney()
    {
        return money;
    }

}

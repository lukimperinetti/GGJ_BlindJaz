using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CharacterManager : MonoBehaviour
{
    public int fatigue = 0;
    public int reputation = 0;
    public int reputationLevel = 0;
    public int money = 0;

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
        }
    }

}

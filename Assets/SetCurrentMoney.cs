using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetCurrentMoney : MonoBehaviour
{
    private Text displmayMoney;
    [SerializeField] private CharacterManager player;

    void Update()
    {
        displmayMoney = GetComponent<Text>();
        displmayMoney.text = player.money.ToString() + " $";
    }
}

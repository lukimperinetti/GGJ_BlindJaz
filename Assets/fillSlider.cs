using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class fillSlider : MonoBehaviour
{
    public int Id;
    [SerializeField] private CharacterManager player;

    // Update is called once per frame
    void Update()
    {
        switch (Id)
        {
            case 0:
                GetComponent<UnityEngine.UI.Slider>().value = 1 - player.getFatigue() / 100f;
                break;
            case 1:
                GetComponent<UnityEngine.UI.Slider>().value = (float)(player.getReputation() / (Math.Pow(2, player.getReputationLevel()))) / 100f;
                break;
        }
    }
}

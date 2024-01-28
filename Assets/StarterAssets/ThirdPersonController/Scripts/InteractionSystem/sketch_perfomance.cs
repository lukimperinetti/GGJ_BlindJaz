using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AIPackage;
using UnityEngine.UI;

public class sketch_perfomance : MonoBehaviour, IInteractable
{
    public int id;
    [SerializeField] private string _prompt;
    public string InteractionPrompt => _prompt;
    [SerializeField] private CharacterManager player;
    [SerializeField] private AIPackage.DayAndNightControl dayAndNightControl;
    [SerializeField] private PopUpMessage popUpMessage;
    [SerializeField] private PopUpMessageTime popUpMessageTime;
    [SerializeField] private Image fade;
    private bool fadeIn = false;
    private bool fadeOut = false;

    private void Update()
    {
        if (fadeIn)
        {
            FadeIn();
        }
        if (fadeOut)
        {
            FadeOut();
        }
    }

    public bool Interact(Interactor interactor)
    {
        if (player.getFatigue() >= 90)
        {
            popUpMessage.showMessage("You are too tired to perform", 3);
            return false;
        }
        switch (id)
        {
            case 0:
                if (!fadeIn && !fadeOut)
                {
                    fadeIn = true;
                    player.GetComponent<CharacterController>().enabled = false;
                }
                break;
            case 1:
                if (player.getReputationLevel() < 1)
                {
                    popUpMessage.showMessage("You need to be at least level 1 to perform here", 3);
                }
                else if (dayAndNightControl.currentTime >= 0.08f && dayAndNightControl.currentTime <= 0.73f)
                {
                    popUpMessage.showMessage("Comedie club not open yet. Come back between 18h and 2h", 3);
                    return false;
                }
                else
                {
                    if (!fadeIn && !fadeOut)
                    {
                        fadeIn = true;
                        player.GetComponent<CharacterController>().enabled = false;
                    }
                }
                break;
        }


        return true;
    }

    private void FadeIn()
    {
        fade.GetComponent<Image>().color = new Color(0, 0, 0, fade.GetComponent<Image>().color.a + 0.01f);
        if (fade.GetComponent<Image>().color.a >= 1.25f)
        {
            fadeOut = true;
            fadeIn = false;
            IncrementeStats();
        }
    }

    private void FadeOut()
    {
        fade.GetComponent<Image>().color = new Color(0, 0, 0, fade.GetComponent<Image>().color.a - 0.01f);
        if (fade.GetComponent<Image>().color.a <= 0)
        {
            fadeOut = false;
            player.GetComponent<CharacterController>().enabled = true;

        }
    }

    private void IncrementeStats()
    {
        switch (id)
        {
            case 0:
                player.addFatigue(20);
                player.addReputation(10);
                player.addMoney(Random.Range(10, 20));
                dayAndNightControl.currentTime += 0.2f;
                popUpMessageTime.showMessage("+5h", 2);
                break;
            case 1:
                player.addFatigue(10);
                player.addReputation(20);
                dayAndNightControl.currentTime += 0.08f;
                popUpMessageTime.showMessage("+2h", 2);
                break;

        }
    }
}

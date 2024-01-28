using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AIPackage;
using UnityEngine.UI;

public class sketch_perfomance : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;
    public string InteractionPrompt => _prompt;
    [SerializeField] private CharacterManager player;
    [SerializeField] private AIPackage.DayAndNightControl dayAndNightControl;
    [SerializeField] private PopUpMessage popUpMessage;
    [SerializeField] private PopUpMessageReputation popUpMessageReputation;
    [SerializeField] private PopUpMessageFatigue popUpMessageFatigue;
    [SerializeField] private PopUpMessageMoney popUpMessageMoney;
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
        if (player.fatigue >= 90)
        {
            popUpMessage.showMessage("You are too tired to perform", 3);
            return false;
        }
        if (!fadeIn && !fadeOut)
        {
            fadeIn = true;
            player.GetComponent<CharacterController>().enabled = false;
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
        player.fatigue += 10;
        popUpMessageFatigue.showMessage("-10", 2);
        player.reputation += 10;
        popUpMessageReputation.showMessage("+10", 2);
        player.money += 10;
        popUpMessageMoney.showMessage("+10", 2);
        dayAndNightControl.currentTime += 0.2f;
        popUpMessageTime.showMessage("+5h", 2);
    }
}

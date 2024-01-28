using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rest : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;
    public string InteractionPrompt => _prompt;
    [SerializeField] private CharacterManager player;
    [SerializeField] private AIPackage.DayAndNightControl dayAndNightControl;
    [SerializeField] private Image fade;
    private bool fadeIn = false;
    private bool fadeOut = false;
    [SerializeField] private PopUpMessage popUpMessage;
    [SerializeField] private PopUpMessageFatigue popUpMessageFatigue;
    [SerializeField] private PopUpMessageTime popUpMessageTime;

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
        player.rest();
        popUpMessage.showMessage("You are well rested", 3);
        dayAndNightControl.currentTime += 0.3f;
        popUpMessageTime.showMessage("+7h", 2);
    }

}

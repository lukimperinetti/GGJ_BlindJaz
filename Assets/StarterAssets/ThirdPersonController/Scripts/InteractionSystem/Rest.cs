using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rest : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;
    public string InteractionPrompt => _prompt;
    [SerializeField] private CharacterManager player;
    [SerializeField] private AIPackage.DayAndNightControl dayAndNightControl;
    [SerializeField] private Fade fade;


    public bool Interact(Interactor interactor)
    {
        fade.FadeIn();
        player.fatigue = 0;
        dayAndNightControl.currentTime += 0.3f;

        return true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AIPackage;

public class sketch_perfomance : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;
    public string InteractionPrompt => _prompt;
    [SerializeField] private CharacterManager player;
    [SerializeField] private AIPackage.DayAndNightControl dayAndNightControl;
    [SerializeField] private PopUpMessage popUpMessage;

    public bool Interact(Interactor interactor)
    {
        if (player.fatigue >= 90)
        {
            popUpMessage.showMessage("You are too tired to perform", 3);
            return false;
        }
        player.fatigue += 10;
        player.reputation += 10;
        player.money += 10;
        dayAndNightControl.currentTime += 0.2f;

        return true;
    }

}

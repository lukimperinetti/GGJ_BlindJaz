using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sketch_perfomance : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;
    public string InteractionPrompt => _prompt;
    [SerializeField] private CharacterManager player;

    public bool Interact(Interactor interactor)
    {
        player.fatigue += 10;
        player.reputation += 10;
        player.money += 10;

        return true;
    }

}

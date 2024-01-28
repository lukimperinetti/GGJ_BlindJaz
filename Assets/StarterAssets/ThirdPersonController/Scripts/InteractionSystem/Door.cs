using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;
    [SerializeField] GameObject player;
    public string InteractionPrompt => _prompt;
    private Vector3 posIn = new Vector3(-14f, 0.18f, -165.62f);
    private Vector3 posOut = new Vector3(-5.18f, 0.1f, -158.24f);
    public bool Interact(Interactor interactor)
    {
        player.GetComponent<CharacterController>().enabled = false;
        if (player.transform.position.z < -164f)
        {
            player.transform.position = posOut;
        }
        else
        {
            player.transform.position = posIn;
        }
        player.GetComponent<CharacterController>().enabled = true;

        return true;
    }
}

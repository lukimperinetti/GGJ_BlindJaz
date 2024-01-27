using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;
    [SerializeField] GameObject player;
    [SerializeField] private CharacterController _controller;

    public string InteractionPrompt => _prompt;
    /*public Vector3 destinationPosition = new Vector3(-10, 0.2f, -158.24f);*/

    public bool Interact(Interactor interactor)
    {
        Debug.Log("toto !");

        _controller.enabled = false;
        player.transform.position = new Vector3(-14f, 0.18f, -165.62f);
        _controller.enabled = true;

        return true;
    }
}

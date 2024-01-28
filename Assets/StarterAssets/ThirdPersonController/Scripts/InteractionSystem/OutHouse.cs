using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutHouse : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;
    [SerializeField] Transform player;
    public string InteractionPrompt => _prompt;
    /*public Vector3 destinationPosition = new Vector3(-10, 0.2f, -158.24f);*/

    public bool Interact(Interactor interactor)
    {

        Debug.Log("toto !");
        player.transform.position = new Vector3(-4.47f, 0.2f, -161.4f);
        return true;
    }
}

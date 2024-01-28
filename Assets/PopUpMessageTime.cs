using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpMessageTime : MonoBehaviour
{
    private Text popupText;
    public string message;
    public int compteur = 0;

    // Update is called once per frame
    void Update()
    {
        if (compteur > 0)
        {
            popupText = GetComponent<Text>();
            popupText.text = message;
            compteur--;
        }
        else
        {
            popupText = GetComponent<Text>();
            popupText.text = "";
        }
    }

    public void showMessage(string message, int compteur)
    {
        this.message = message;
        this.compteur = compteur * 240;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Fade : MonoBehaviour
{
    private bool fadeIn = false;
    private bool fadeOut = false;
    private void Update()
    {
        if (fadeIn)
        {
            GetComponent<Image>().color = new Color(0, 0, 0, GetComponent<Image>().color.a + 0.01f);
            if (GetComponent<Image>().color.a >= 1.25f)
            {
                fadeOut = true;
                fadeIn = false;
            }
        }
        if (fadeOut)
        {
            GetComponent<Image>().color = new Color(0, 0, 0, GetComponent<Image>().color.a - 0.01f);
            if (GetComponent<Image>().color.a <= 0)
            {
                fadeOut = false;
            }
        }
    }

    public void FadeIn()
    {
        if (!fadeIn && !fadeOut)
            fadeIn = true;
    }
}

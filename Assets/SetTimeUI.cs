using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetTimeUI : MonoBehaviour
{
    private Text timeText;
    [SerializeField] private AIPackage.DayAndNightControl dayAndNightControl;

    void Update()
    {
        timeText = GetComponent<Text>();
        timeText.text = "Time: " + (dayAndNightControl.currentTime * 24).ToString("F0") + "h";
    }

}

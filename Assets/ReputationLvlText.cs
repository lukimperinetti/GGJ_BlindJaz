using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReputationLvlText : MonoBehaviour
{
    private Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        text.text = "Lvl 0";
    }

    public void setLvl(int lvl)
    {
        text.text = "Lvl " + lvl;
    }
}

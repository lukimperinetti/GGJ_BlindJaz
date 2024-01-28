using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonNext : MonoBehaviour
{

    public GameObject img01;
    public GameObject img02;
    /*public GameObject Frame03;*/
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BackgroundChanger()
    {
        /*Frame01.SetActive(true);
        if (Frame02 == false)
        {
            Frame01.SetActive(false);
            Frame02.SetActive(true);
        }
        if (Frame02 ==  true)
        {
            Frame03.SetActive(true);
        }*/

        img01.SetActive(false);
        img02.SetActive(true);
    }
}
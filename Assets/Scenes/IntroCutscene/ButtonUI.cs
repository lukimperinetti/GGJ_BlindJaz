using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonUI : MonoBehaviour
{
    [SerializeField] private string newGameLevel = "Playground"; // Use camelCase for variable names

    public GameObject im1;
    public GameObject im2;
    public GameObject im3;
    public GameObject canvasImageGameObject; // Reference to the GameObject with the Image component
    private Image canvasImage;
    public GameObject ButtonNext; // Reference to the GameObject with the Button component
    private int currentIndex = 0;

    private void Start()
    {
        // Get the Image component in Start to avoid repeated calls
        if (canvasImageGameObject != null)
        {
            canvasImage = canvasImageGameObject.GetComponent<Image>();
        }

        // Disable im2 and im3 at the start
        im2.SetActive(false);
        im3.SetActive(false);
    }

    public void OnButtonClick()
    {
        currentIndex++;
        Debug.Log("Button clicked");

        if (currentIndex == 1)
        {
            // Enable im2 and change the canvas image
            im2.SetActive(true);
            ChangeCanvasImage(im2.GetComponent<Image>().sprite);
        }
        else if (currentIndex == 2)
        {
            // Enable im3 and change the canvas image
            im3.SetActive(true);
            ChangeCanvasImage(im3.GetComponent<Image>().sprite);
            ButtonNext.SetActive(false); // Disable the next button

        }
        else
        {
            // Reset to the first image and disable im2 and im3
            currentIndex = 0;
            im2.SetActive(false);
            im3.SetActive(false);
            ChangeCanvasImage(im1.GetComponent<Image>().sprite);
        }
    }

    private void ChangeCanvasImage(Sprite newSprite)
    {
        // Change the sprite of the Canvas Image
        if (canvasImage != null)
        {
            canvasImage.sprite = newSprite;
        }
    }

    public void NewGameBtn()
    {
        // Load the new game level
        SceneManager.LoadScene(newGameLevel);
    }

    // public void QuitGameBtn()
    // {
    //     // Quit the game
    //     Debug.Log("Quit");
    //     Application.Quit();
    // }
}

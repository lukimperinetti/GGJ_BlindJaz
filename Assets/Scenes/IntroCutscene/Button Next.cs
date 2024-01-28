using UnityEngine;
using UnityEngine.UI;

public class ButtonNext : MonoBehaviour
{
    public GameObject im1;
    public GameObject im2;
    public GameObject im3;

    public GameObject canvasImageGameObject; // Reference to the GameObject with the Image component
    private Image canvasImage; // Reference to the Image component on the Canvas
    private int currentIndex = 0;

    private void Start()
    {
        canvasImage = canvasImageGameObject.GetComponent<Image>(); // Get the Image component
        im2.SetActive(false); // Disable im2 at the start
        im3.SetActive(false); // Disable im3 at the start

    }

    public void OnButtonClick()
    {
        currentIndex++;
        Debug.Log("clicked");


        if (currentIndex == 1)
        {
            im2.SetActive(true); // Enable im2 when the button is clicked
            ChangeCanvasImage(im2.GetComponent<Image>().sprite);
        }
        else if (currentIndex == 2)
        {
            im3.SetActive(true); // Enable im3 when the button is clicked
            ChangeCanvasImage(im3.GetComponent<Image>().sprite);
        }
        else
        {
            currentIndex = 0;
            im2.SetActive(false); // Disable im2 when the button is clicked again
            im3.SetActive(false); // Disable im3 when the button is clicked again
            ChangeCanvasImage(im1.GetComponent<Image>().sprite);
        }
    }

    private void ChangeCanvasImage(Sprite newSprite)
    {
        canvasImage.sprite = newSprite; // Change the sprite of the Canvas Image
    }
}
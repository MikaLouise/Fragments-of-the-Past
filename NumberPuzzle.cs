using UnityEngine;

public class NumberPuzzle : MonoBehaviour
{
    // Buttons to be called
    public GameObject button2;
    public GameObject button4;
    public GameObject button7;
    public GameObject button0; 

    public GameObject chestImage; // Reference to the opened chest image

    bool isChestDisplayed = false; // Track if the chest image is displayed

    void Update()
    {
        // Check if buttons for "2," "4," "7," and "0" are all active (visible)
        if (button2.activeSelf && button4.activeSelf && button7.activeSelf && button0.activeSelf)
        {
            if (!isChestDisplayed)
            {
                DisplayChestImage();
                isChestDisplayed = true; // Set the flag to prevent repeated button display
            }
        }
    }

    void DisplayChestImage()
    {
        chestImage.SetActive(true); // Display the chest image
    }

}


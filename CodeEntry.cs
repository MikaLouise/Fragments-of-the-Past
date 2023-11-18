using UnityEngine;
using UnityEngine.UI;

public class CodeEntry : MonoBehaviour
{
    public string requiredCode = "9453"; // Required code
    private string enteredCode = ""; // Store the entered code
    public GameObject imageToDisplay; // Reference to the image that displays after entering the code

    // Function to add a button press to the entered code
    public void AddButtonPress(string buttonValue)
    {
        if (enteredCode.Length < requiredCode.Length)
        {
            Debug.Log("Pressed: " + buttonValue);
            enteredCode += buttonValue;
        }
    }

    // Function to delete the last button press
    public void DeleteButtonPress()
    {
        if (enteredCode.Length > 0)
        {
            enteredCode = enteredCode.Substring(0, enteredCode.Length - 1);
            Debug.Log("Deleted: " + enteredCode);
        }
    }

    // Function to check the entered code and display the image
    public void CheckCode()
    {
        if (enteredCode == requiredCode)
        {
            Debug.Log("Code is correct");
            // Code is correct, display the image
            imageToDisplay.SetActive(true);
        }
        else
        {
            Debug.Log("Code is incorrect");
        }
    }
}






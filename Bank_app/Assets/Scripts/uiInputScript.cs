using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class uiInputScript : MonoBehaviour
{
    private string inputText;

    public void stringInput(string input)
    {
        inputText = input;
        Debug.Log(inputText);

        PlayerPrefs.SetString("email", inputText);
        Debug.Log("Email_saved");
    }
}

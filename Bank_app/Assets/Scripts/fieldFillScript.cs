using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class fieldFillScript : MonoBehaviour
{
    public TMP_InputField email;
    public TMP_InputField contactNumber;
    public TMP_InputField password;
    //public TMP_InputField userName;
    public Button nextButton;

    void Start()
    {
        nextButton.interactable = false;
    }

    public void confirmInput()
    {
        if ( !string.IsNullOrEmpty (email.text) && !string.IsNullOrEmpty (contactNumber.text) && !string.IsNullOrEmpty (password.text)) //&& !string.IsNullOrEmpty (userName.text))
        {
            nextButton.interactable = true;
        }
        else
        {
            nextButton.interactable = false;
        }
    }
}

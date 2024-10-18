using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contactNumberScript : MonoBehaviour
{
    private string contactNumber;

    public void stringInput(string input)
    {
        contactNumber = input;
        Debug.Log(contactNumber);

        PlayerPrefs.SetString("number", contactNumber);
    }
}

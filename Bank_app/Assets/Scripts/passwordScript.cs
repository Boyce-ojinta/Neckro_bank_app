using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class passwordScript : MonoBehaviour
{
    private string password;
    

    public void stringInput(string input)
    {
        password = input;
        Debug.Log(password);

        PlayerPrefs.SetString("passwordSave", password);
        Debug.Log("Password_saved");
    }
}

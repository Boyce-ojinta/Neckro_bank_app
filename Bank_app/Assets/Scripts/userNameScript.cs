using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class userNameScript : MonoBehaviour
{
   private string userName;

    public void stringInput(string input)
    {
        userName = input;
        Debug.Log(userName);

        PlayerPrefs.SetString("Username", userName);
        Debug.Log("Username saved" + userName);
    }
}

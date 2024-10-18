using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class displayNameScript : MonoBehaviour
{
    public TextMeshProUGUI userNameText;

    // Start is called before the first frame update
    void Start()
    {
       string username = PlayerPrefs.GetString("Username", "User");

       userNameText.text = "Hi, " + username;  
    }

}

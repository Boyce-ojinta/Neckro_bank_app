using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if 
        (PlayerPrefs.HasKey("Username") && PlayerPrefs.HasKey("passwordSave"))
        {
            SceneManager.LoadScene("loginPage");
        }
        else
        {
            SceneManager.LoadScene("signUpPage");
        }
    }
}

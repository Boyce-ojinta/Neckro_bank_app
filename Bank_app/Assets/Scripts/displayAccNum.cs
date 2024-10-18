using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class displayAccNum : MonoBehaviour
{
    public TMP_Text accountNumberText;

    void Start()
    {
        
        userData currentUser = new userData();

        
        accountNumberText.text = currentUser.accountNumber;
    }
}

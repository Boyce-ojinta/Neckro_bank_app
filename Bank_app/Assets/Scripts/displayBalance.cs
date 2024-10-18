using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class displayBalance : MonoBehaviour
{
    public TextMeshProUGUI accountBalance;

    // Start is called before the first frame update
    void Start()
    {
        userData currentUser = new userData();

        accountBalance.text ="₦ " + currentUser.balance.ToString("F2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

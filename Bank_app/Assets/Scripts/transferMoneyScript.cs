using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class transferMoneyScript : MonoBehaviour
{
    public TMP_InputField receiverAccountField; 
    public TMP_InputField amountField; 

    public void transferMoney(string senderAccount, string receiverAccount, float amount)
    {
        userData sender = new userData();
        userData receiver = LoadUserData(receiverAccount);

        if (sender.balance >= amount)
        {
            sender.updateBalance(sender.balance - amount);
            receiver.updateBalance(receiver.balance + amount);

            PlayerPrefs.SetFloat(senderAccount + "_balance", sender.balance);
            PlayerPrefs.SetFloat(receiverAccount + "_balance", receiver.balance);
            PlayerPrefs.Save();

            Debug.Log("Transfer Successful! " + amount + " sent from " + senderAccount + " to " + receiverAccount);
        }
        else
        {
            Debug.LogError("Insufficient funds. Transfer failed.");
        }
    }

    private userData LoadUserData(string accountNumber)
    {
        userData accountUser = new userData
        {
            accountNumber = accountNumber,
            balance = PlayerPrefs.GetFloat(accountNumber + "_balance", 0f)
        };
        return accountUser;
    }

    public void OnTransferButtonClicked()
    {
        string receiverAccount = receiverAccountField.text;
        float amount = float.Parse(amountField.text);

        // Retrieve sender account number from PlayerPrefs
        string senderAccount = PlayerPrefs.GetString("accountNumber");

        // Call the transfer function
        transferMoney(senderAccount, receiverAccount, amount);
    }
}
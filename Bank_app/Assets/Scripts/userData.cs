using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class userData
{
   public string userName;
   public string password;
   public string email;
   public string contactNumber;
   public string accountNumber;
   public float balance;


   public userData ()
   {
    userName = PlayerPrefs.GetString ("Username");
    password = PlayerPrefs.GetString ("passwordSave");
    email = PlayerPrefs.GetString ("email");
    contactNumber = PlayerPrefs.GetString ("number");
    accountNumber = PlayerPrefs.GetString("accountnumber", generateAccountNumber());
    
    balance = 
    PlayerPrefs.GetFloat("currentBalance", 0f);


   }
   private string generateAccountNumber ()
   {
    if (!PlayerPrefs.HasKey ("accountnumber"))
    {
        System.Random rand = new System.Random();
        string accNum = rand.Next(1000000000, 1999999999). ToString();

        PlayerPrefs.SetString("accountNumber", accNum);
        PlayerPrefs.Save();
        return accNum;
    }
    return PlayerPrefs.GetString ("accountNumber");
   }

   public void updateBalance (float newBalance)
   {
    balance = newBalance;
    PlayerPrefs.SetFloat("currentBalance", balance);
    PlayerPrefs.Save();
   }
}

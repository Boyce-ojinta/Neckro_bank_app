using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using TMPro;

public class dummyMoneyScripts : MonoBehaviour
{
    public TextMeshProUGUI popUpMessage; 
    public GameObject popUpPanel;
    public Button closePopUp;         
    private userData newUser;

    void Start()
    {
        InitializeNewUser();
        ShowInitialBalancePopUp();
    }
    void Update()
    {
        if (Input.touchCount > 0);
        {
             Touch touch = Input.GetTouch(0);
             if (touch.phase == TouchPhase.Began && ! IsPointerOverUIObject(touch.position))
             {
                Destroy(popUpPanel);
             }
        } 
    }

        void InitializeNewUser()
    {
        newUser = new userData();

                if (!PlayerPrefs.HasKey("initialDummyMoney"))
        {
            newUser.balance = 100000f;  
            PlayerPrefs.SetFloat("currentBalance", newUser.balance);
            PlayerPrefs.SetInt("initialDummyMoney", 1);  
            PlayerPrefs.Save();
        }
    }

    
    public void ShowInitialBalancePopUp()
    {
        if (PlayerPrefs.GetInt("initialDummyMoney", 0) == 1)
        {
            popUpMessage.text = "You've been credited with ₦100,000 to explore the app!";
            popUpPanel.SetActive(true);  
        }
    }

    
    public void HidePopUp()
    {
        popUpPanel.SetActive(false);
    }

    private bool IsPointerOverUIObject(Vector2 position)
    {
        PointerEventData eventData = new PointerEventData(EventSystem.current);
        eventData.position = position;

        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventData, results);
        return results.Count > 0;
    }

}

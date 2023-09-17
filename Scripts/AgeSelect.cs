using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class AgeSelect : MonoBehaviour
{
    //Dropdown m_Dropdown;
    public bool forEveryone;
    //public bool forYoungPeople;
    //public Button btnEveryone;
    //public Button btnYoungPeople;
    void Start() {
        forEveryone = true;
        PlayerPrefs.SetInt("country", 0);

        // m_Dropdown = GetComponent<Dropdown>();
        // m_Dropdown.onValueChanged.AddListener(delegate
        // {
        //     selectvalue(m_Dropdown);
        // });
        //forYoungPeople = false;
    }

    public void everyoneClicked() {
        //Debug.Log(Button.name);
        forEveryone = true;
        //forYoungPeople = false;
        PlayerPrefs.SetInt("everyone",1);
        Debug.Log("everyone");
    }

    public void youngPeopleClicked() {
        //forYoungPeople = true;
        forEveryone = false;
        PlayerPrefs.SetInt("everyone",0);
        Debug.Log("young" + forEveryone);
    }
    // public void OnSelect (BaseEventData eventData) 
	// {
	// 	Debug.Log (this.gameObject.name + " was selected");
	// }

    public void selectvalue(TMP_Dropdown dropDown)
    {
        Debug.Log("DROP DOWN CHANGED -> " + dropDown.value);
        PlayerPrefs.SetInt("country", dropDown.value);
    }
}

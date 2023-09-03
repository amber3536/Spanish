using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class AgeSelect : MonoBehaviour
{
    public bool forEveryone;
    //public bool forYoungPeople;
    //public Button btnEveryone;
    //public Button btnYoungPeople;
    void Start() {
        forEveryone = true;
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
    public void OnSelect (BaseEventData eventData) 
	{
		Debug.Log (this.gameObject.name + " was selected");
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;
//using UnityEngine.UI;

public class WordToLearn : MonoBehaviour
{
    private Vector2 fingerDownPos;
	private Vector2 fingerUpPos;
    //public AgeSelect age;
    private bool everyone;
    //private AgeSelect age;
    //public Button everyoneBtn;
    //public Button youngPeopleBtn;

	public bool detectSwipeAfterRelease = false;
    public Words word;
	public float SWIPE_THRESHOLD = 20f;
    public TextMeshProUGUI curr;
    public TextMeshProUGUI m_Object;

    int num;
    // Start is called before the first frame update
    void Start()
    {
        //age = GetComponent<AgeSelect>();
        num = 0;
        everyone = (PlayerPrefs.GetInt("everyone",0) != 0);
        Debug.Log("length " + word.everyoneWords.Length);

        if (everyone) {
            num = Random.Range(0, word.everyoneWords.Length);
            //Debug.Log(age.forEveryone);
            curr.text = word.everyoneWords[num];
            m_Object.text = "toque";
        }
        else {
            //Debug.Log(age.forEveryone);
            curr.text = word.youngWords[num];
            m_Object.text = "toque";
        }
    }

 
    public void Definition() 
    {
        
        //if (m_Object.text == everyoneWords[0]) 
        if (everyone) {
            m_Object.text = word.everyoneDefinition[num];
            // Debug.Log(num);
            // if (m_Object.text == word.everyoneWords[num])
            //     m_Object.text = word.everyoneDefinition[num];
            // else if (m_Object.text == word.everyoneDefinition[num]) 
            //     m_Object.text = word.everyoneWords[num];
        }
        else {
            m_Object.text = word.youngDefinition[num];
            // if (m_Object.text == word.youngWords[num])
            //     m_Object.text = word.youngDefinition[num];
            // else if (m_Object.text == word.youngDefinition[num]) 
            //     m_Object.text = word.youngWords[num];
        }
    
        
        
    }

	// Update is called once per frame
	void Update ()
	{

		foreach (Touch touch in Input.touches) {
			if (touch.phase == TouchPhase.Began) {
				fingerUpPos = touch.position;
				fingerDownPos = touch.position;
			}

			//Detects Swipe while finger is still moving on screen
			// if (touch.phase == TouchPhase.Moved) {
			// 	if (!detectSwipeAfterRelease) {
			// 		fingerDownPos = touch.position;
			// 		DetectSwipe ();
			// 	}
			// }

			//Detects swipe after finger is released from screen
			if (touch.phase == TouchPhase.Ended) {
				fingerDownPos = touch.position;
				DetectSwipe ();
			}
		}
	}

	void DetectSwipe ()
	{
		
		if (VerticalMoveValue () > SWIPE_THRESHOLD && VerticalMoveValue () > HorizontalMoveValue ()) {
			Debug.Log ("Vertical Swipe Detected!");
			if (fingerDownPos.y - fingerUpPos.y > 0) {
				OnSwipeUp ();
			} else if (fingerDownPos.y - fingerUpPos.y < 0) {
				OnSwipeDown ();
			}
			fingerUpPos = fingerDownPos;

		} else if (HorizontalMoveValue () > SWIPE_THRESHOLD && HorizontalMoveValue () > VerticalMoveValue ()) {
			Debug.Log ("Horizontal Swipe Detected!");
			if (fingerDownPos.x - fingerUpPos.x > 0) {
				OnSwipeRight ();
			} else if (fingerDownPos.x - fingerUpPos.x < 0) {
				OnSwipeLeft ();
			}
			fingerUpPos = fingerDownPos;

		} else {
			Debug.Log ("No Swipe Detected!");
            Definition();
		}
	}

	float VerticalMoveValue ()
	{
		return Mathf.Abs (fingerDownPos.y - fingerUpPos.y);
	}

	float HorizontalMoveValue ()
	{
		return Mathf.Abs (fingerDownPos.x - fingerUpPos.x);
	}

	void OnSwipeUp ()
	{	
		//Do something when swiped up
	}

	void OnSwipeDown ()
	{
		//Do something when swiped down
	}

	void OnSwipeLeft ()
	{
		//Do something when swiped left
        //m_Object.text = "cat";
        if (everyone) {
            //num = (num + 1)%5;
            //Debug.Log("num is "+ num);
            num = Random.Range(0, word.everyoneWords.Length);

            curr.text = word.everyoneWords[num];
            m_Object.text = "toque";
            //Debug.Log(age.forEveryone);
            //m_Object.text = word.everyoneWords[num];
        }
        else {
            curr.text = word.youngWords[num];
            m_Object.text = "toque";
            //Debug.Log(age.forEveryone);
            //m_Object.text = word.youngWords[num];
        }
	}

	void OnSwipeRight ()
	{
        Debug.Log("right");
		//Do something when swiped right
	}

}

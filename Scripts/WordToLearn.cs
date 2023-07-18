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
    //public Button everyoneBtn;
    //public Button youngPeopleBtn;

	public bool detectSwipeAfterRelease = false;

	public float SWIPE_THRESHOLD = 20f;
    public TextMeshProUGUI m_Object;
    string[] words = {"I'm beat.", "a turn off"};
    string[] definition = {"Estoy agotado.", "algo que no me apetece"};
    // Start is called before the first frame update
    void Start()
    {
        m_Object.text = words[0];
    }

 
    public void Definition() 
    {
        if (m_Object.text == words[0]) 
        {
            m_Object.text = definition[0];
        }
        else if (m_Object.text == definition[0]) {
            m_Object.text = words[0];
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
			if (touch.phase == TouchPhase.Moved) {
				if (!detectSwipeAfterRelease) {
					fingerDownPos = touch.position;
					DetectSwipe ();
				}
			}

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
        m_Object.text = "cat";
	}

	void OnSwipeRight ()
	{
		//Do something when swiped right
	}

}

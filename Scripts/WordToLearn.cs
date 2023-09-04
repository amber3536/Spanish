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
    public TextMeshProUGUI def;
    public TextMeshProUGUI example;

    int num;
    // Start is called before the first frame update
    void Start()
    {
        //age = GetComponent<AgeSelect>();
        num = 0;
        everyone = (PlayerPrefs.GetInt("everyone",0) != 0);
        Debug.Log("length " + word.everyoneWords.Length);

        updateWord();
        // if (everyone) {
        //     num = Random.Range(0, word.everyoneWords.Length);
        //     curr.text = word.everyoneWords[num];
        //     def.text = "definición";
        // }
        // else {
        //     curr.text = word.youngWords[num];
        //     def.text = "definición";
        // }
    }

 
    public void Definition() 
    {
        if (everyone) {
            def.text = word.everyoneDefinition[num];
        }
        else {
            def.text = word.youngDefinition[num];
        }   
    }

    public void Example() {
        if (everyone) {
            example.text = word.everyoneExample[num];
        }
        else {
            example.text = word.youngExample[num];
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
        updateWord();

	}

	void OnSwipeRight ()
	{
        Debug.Log("right");
		//Do something when swiped right
	}

    private void updateWord() {
        if (everyone) {
            num = Random.Range(0, word.everyoneWords.Length);
            curr.text = word.everyoneWords[num];
            def.text = "definición";
            example.text = "ejemplo";
        }
        else {
            num = Random.Range(0, word.youngWords.Length);
            curr.text = word.youngWords[num];
            def.text = "definición";
            example.text = "ejemplo";
        }
    }

}

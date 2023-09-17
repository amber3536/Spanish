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
    private int country;

	public bool detectSwipeAfterRelease = false;
    public Words word;
	public float SWIPE_THRESHOLD = 20f;
    public TextMeshProUGUI curr;
    public TextMeshProUGUI def;
    public TextMeshProUGUI example;
    public AudioSource E_0;
    public AudioSource E_1;
    public AudioSource E_2;
    public AudioSource E_3;
    public AudioSource E_4;
    public AudioSource E_5;
    public AudioSource E_6;
    public AudioSource E_7;
    public AudioSource E_8;
    public AudioSource E_9;
    public AudioSource E_10;
    public AudioSource E_11;
    public AudioSource E_12;
    public AudioSource E_13;
    public AudioSource E_14;
    public AudioSource E_15;
    public AudioSource E_16;
    public AudioSource E_17;
    public AudioSource E_18;
    public AudioSource E_19;
    public AudioSource E_20;
    public AudioSource E_21;
    public AudioSource E_22;
    public AudioSource E_23;
    public AudioSource E_24;
    public AudioSource E_25;
    public AudioSource E_26;
    public AudioSource E_27;
    public AudioSource E_28;
    public AudioSource E_29;
    public AudioSource E_30;
    public AudioSource E_31;
    public AudioSource E_32;
    public AudioSource E_33;
    public AudioSource E_34;
    public AudioSource E_35_36;
    public AudioSource E_37;
    public AudioSource E_38;
    public AudioSource E_39;
    public AudioSource E_40;
    public AudioSource E_41;
    public AudioSource E_42_43;
    public AudioSource E_44;
    public AudioSource E_45;
    public AudioSource E_46;
    public AudioSource E_47;
    public AudioSource E_48;
    public AudioSource E_49;
    public AudioSource E_50;
    public AudioSource E_51;
    public AudioSource E_52;
    public AudioSource E_53;
    public AudioSource E_54;
    public AudioSource E_55;
    public AudioSource E_56;
    public AudioSource E_57;
    public AudioSource E_58;
    public AudioSource E_59;
    public AudioSource E_60;
    public AudioSource E_61;
    public AudioSource E_62;
    public AudioSource E_63;
    public AudioSource E_64;
    public AudioSource E_65;
    public AudioSource E_66;
    public AudioSource E_67;
    public AudioSource E_68;
    public AudioSource E_69;
    public AudioSource E_70;
    public AudioSource E_71;
    public AudioSource E_72;
    public AudioSource E_73;
    public AudioSource E_74;
    public AudioSource E_75;
    public AudioSource E_76;
    public AudioSource E_77;
    public AudioSource E_78;
    public AudioSource E_79;
    public AudioSource E_80_81;
    public AudioSource E_82;
    public AudioSource E_83;
    public AudioSource E_84;
    public AudioSource E_85;
    public AudioSource E_86;
    public AudioSource E_87;
    public AudioSource E_88;
    public AudioSource E_89;
    public AudioSource E_90;
    public AudioSource E_91;
    public AudioSource E_92;
    public AudioSource E_93;
    public AudioSource E_94;
    public AudioSource E_95;
    public AudioSource E_96;
    public AudioSource E_97;
    public AudioSource E_98;
    public AudioSource E_99;
    public AudioSource E_100;
    public AudioSource E_101;
    public AudioSource E_102;
    public AudioSource E_103;
    public AudioSource E_104;

    int num;
    // Start is called before the first frame update
    void Start()
    {
        //age = GetComponent<AgeSelect>();
        num = 0;
        everyone = (PlayerPrefs.GetInt("everyone",0) != 0);
        Debug.Log("length " + word.everyoneWords.Length);
        country = PlayerPrefs.GetInt("country", 0);
        Debug.Log("country " + country);

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
            switch(country) 
            {
                case 0:
                    def.text = word.everyoneDefEnglish[num];
                    break;
                case 1:
                    def.text = word.everyoneDefSpanish[num];
                    break;
                case 2:
                    def.text = word.everyoneDefMandarin[num];
                    break;
                case 3:
                    def.text = word.everyoneDefHindi[num];
                    break;
            }
            
        }
        // else {
        //     def.text = word.youngDefinition[num];
        // }   
    }

    public void Example() {
        // if (everyone) {
        //     example.text = word.everyoneExample[num];
        // }
        // else {
        //     example.text = word.youngExample[num];
        // }
    }

    public void PlayAudio() {
        switch(num)
        {
            case 0:
                E_0.Play();
                break;
            case 1:
                E_1.Play();
                break;
            case 2:
                E_2.Play();
                break;
            case 3:
                E_3.Play();
                break;
            case 4:
                E_4.Play();
                break;
            case 5:
                E_5.Play();
                break;
            case 6:
                E_6.Play();
                break;
            case 7:
                E_7.Play();
                break;
            case 8:
                E_8.Play();
                break;
            case 9:
                E_9.Play();
                break;
            case 10:
                E_10.Play();
                break;
            case 11:
                E_11.Play();
                break;
            case 12:
                E_12.Play();
                break;
            case 13:
                E_13.Play();
                break;
            case 14:
                E_14.Play();
                break;
            case 15:
                E_15.Play();
                break;
            case 16:
                E_16.Play();
                break;
            case 17:
                E_17.Play();
                break;
            case 18:
                E_18.Play();
                break;
            case 19:
                E_19.Play();
                break;
            case 20:
                E_20.Play();
                break;
            case 21:
                E_21.Play();
                break;
            case 22:
                E_22.Play();
                break;
            case 23:
                E_23.Play();
                break;
            case 24:
                E_24.Play();
                break;
            case 25:
                E_25.Play();
                break;
            case 26:
                E_26.Play();
                break;
            case 27:
                E_27.Play();
                break;
            case 28:
                E_28.Play();
                break;
            case 29:
                E_29.Play();
                break;
            case 30:
                E_30.Play();
                break;
            case 31:
                E_31.Play();
                break;
            case 32:
                E_32.Play();
                break;
            case 33:
                E_33.Play();
                break;
            case 34:
                E_34.Play();
                break;
            case 35:
                E_35_36.Play();
                break;
            case 36:
                E_35_36.Play();
                break;
            case 37:
                E_37.Play();
                break;
            case 38:
                E_38.Play();
                break;
            case 39:
                E_39.Play();
                break;
            case 40:
                E_40.Play();
                break;
            case 41:
                E_41.Play();
                break;
            case 42:
                E_42_43.Play();
                break;
            case 43:
                E_42_43.Play();
                break;
            case 44:
                E_44.Play();
                break;
            case 45:
                E_45.Play();
                break;
            case 46:
                E_46.Play();
                break;
            case 47:
                E_47.Play();
                break;
            case 48:
                E_48.Play();
                break;
            case 49:
                E_49.Play();
                break;
            case 50:
                E_50.Play();
                break;
            case 51:
                E_51.Play();
                break;
            case 52:
                E_52.Play();
                break;
            case 53:
                E_53.Play();
                break;
            case 54:
                E_54.Play();
                break;
            case 55:
                E_55.Play();
                break;
            case 56:
                E_56.Play();
                break;
            case 57:
                E_57.Play();
                break;
            case 58:
                E_58.Play();
                break;
            case 59:
                E_59.Play();
                break;
            case 60:
                E_60.Play();
                break;
            case 61:
                E_61.Play();
                break;
            case 62:
                E_62.Play();
                break;
            case 63:
                E_63.Play();
                break;
            case 64:
                E_64.Play();
                break;
            case 65:
                E_65.Play();
                break;
            case 66:
                E_66.Play();
                break;
            case 67:
                E_67.Play();
                break;
            case 68:
                E_68.Play();
                break;
            case 69:
                E_69.Play();
                break;
            case 70:
                E_70.Play();
                break;
            case 71:
                E_71.Play();
                break;
            case 72:
                E_72.Play();
                break;
            case 73:
                E_73.Play();
                break;
            case 74:
                E_74.Play();
                break;
            case 75:
                E_75.Play();
                break;
            case 76:
                E_76.Play();
                break;
            case 77:
                E_77.Play();
                break;
            case 78:
                E_78.Play();
                break;
            case 79:
                E_79.Play();
                break;
            case 80:
                E_80_81.Play();
                break;
            case 81:
                E_80_81.Play();
                break;
            case 82:
                E_82.Play();
                break;
            case 83:
                E_83.Play();
                break;
            case 84:
                E_84.Play();
                break;
            case 85:
                E_85.Play();
                break;
            case 86:
                E_86.Play();
                break;
            case 87:
                E_87.Play();
                break;
            case 88:
                E_88.Play();
                break;
            case 89:
                E_89.Play();
                break;
            case 90:
                E_90.Play();
                break;
            case 91:
                E_91.Play();
                break;
            case 92:
                E_92.Play();
                break;
            case 93:
                E_93.Play();
                break;
            case 94:
                E_94.Play();
                break;
            case 95:
                E_95.Play();
                break;
            case 96:
                E_96.Play();
                break;
            case 97:
                E_97.Play();
                break;
            case 98:
                E_98.Play();
                break;
            case 99:
                E_99.Play();
                break;
            case 100:
                E_100.Play();
                break;
            case 101:
                E_101.Play();
                break;
            case 102:
                E_102.Play();
                break;
            case 103:
                E_103.Play();
                break;
            case 104:
                E_104.Play();
                break;
            // default:
            //     E_0.Play();
            //     break;
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
            //Definition();
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

            switch(country) 
            {
                case 0:
                    def.text = "definition";
                    example.text = "example";
                    break;
                case 1:
                    def.text = "definición";
                    example.text = "ejemplo";
                    break;
                case 2:
                    def.text = "定义";
                    example.text = "例子";
                    break;
                case 3:
                    def.text = "परिभाषा";
                    example.text = "उदाहरण";
                    break;
            }
            
        }
        else {
            num = Random.Range(0, word.youngWords.Length);
            curr.text = word.youngWords[num];
            def.text = "definición";
            example.text = "ejemplo";
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class Fill_in_Blanks : MonoBehaviour
{
    public TextMeshProUGUI para;
    public TextMeshProUGUI ans1;
    public TextMeshProUGUI ans2;
    public TextMeshProUGUI ans3;
    public Paragraphs p;
    public Words word;
    private bool everyone;
    public GameObject particles;
    private int sel;
    // Start is called before the first frame update
    void Start()
    {
        particles.SetActive(false);
        everyone = (PlayerPrefs.GetInt("everyone",0) != 0);

        // just for everyone now
        if (everyone) {
            sel = Random.Range(0, p.paragraph.Length);
            para.text = p.paragraph[sel];
            int[] choices = p.answers[sel];

            // random numbers, one is the right answer
            ans1.text = word.everyoneWords[choices[0]];
            ans2.text = word.everyoneWords[choices[1]];
            ans3.text = word.everyoneWords[choices[2]];
        }
        else {
            int sel = Random.Range(0, p.paragraphY.Length);
            para.text = p.paragraphY[sel];
            int[] choices = p.answersY[sel];

            // random numbers, one is the right answer
            ans1.text = word.youngWords[choices[0]];
            ans2.text = word.youngWords[choices[1]];
            ans3.text = word.youngWords[choices[2]];
        }

    }

    public void btn1Clicked() {
        if (ans1.text == word.everyoneWords[sel]) {
            particles.SetActive(true);
        }
        else {
            ans1.color = Color.red;
        }
    }

    public void btn2Clicked() {
        if (ans2.text == word.everyoneWords[sel]) {
            particles.SetActive(true);
        }
        else {
            ans2.color = Color.red;
        }
    }

    public void btn3Clicked() {
        if (ans3.text == word.everyoneWords[sel]) {
            particles.SetActive(true);
        }
        else {
            ans3.color = Color.red;
        }
    }
}

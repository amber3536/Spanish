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
    //public GameObject particles;
    private int sel;
    public ParticleSystem particleSys;
    // Start is called before the first frame update
    void Start()
    {
        particleSys.Stop();
        //particles.SetActive(false);
        everyone = (PlayerPrefs.GetInt("everyone",0) != 0);
        //particleSys = GetComponent<ParticleSystem>();
        //particleSys.Stop(true);
        changeWords();

    }

    public void btn1Clicked() {
        if (ans1.text == word.everyoneWords[sel]) {
            particleSys.Play();
            clearColors();
            //particles.SetActive(true);
            //StartCoroutine(Pause());
            //particleSys.Stop();
            //particles.SetActive(false);
            changeWords();
        }
        else {
            ans1.color = Color.red;
        }
    }

    public void btn2Clicked() {
        if (ans2.text == word.everyoneWords[sel]) {
            particleSys.Play();
            clearColors();
            //particles.particleSystem.Play();
            //particles.SetActive(true);
            //StartCoroutine(Pause());
            //particleSys.Stop();
            //particles.SetActive(false);
            changeWords();
        }
        else {
            ans2.color = Color.red;
        }
    }

    public void btn3Clicked() {
        if (ans3.text == word.everyoneWords[sel]) {
            particleSys.Play();
            clearColors();
            changeWords();
        }
        else {
            ans3.color = Color.red;
        }
    }

    IEnumerator Pause()
    {
        Debug.Log("hi");
        //print(Time.time);
        yield return new WaitForSeconds(2);
        Debug.Log("bye");
        //print(Time.time);
    }

    private void clearColors() {
        ans1.color = Color.black;
        ans2.color = Color.black;
        ans3.color = Color.black;
    }

    private void changeWords() {
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
}

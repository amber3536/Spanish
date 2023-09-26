using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;
using System.Linq;

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
    public AudioSource correct;
    public AudioSource incorrect;
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
            correct.Play();
            clearColors();
            //particles.SetActive(true);
            //StartCoroutine(Pause());
            //particleSys.Stop();
            //particles.SetActive(false);
            changeWords();
        }
        else if (everyone == false && ans1.text == word.youngWords[sel]) {
            particleSys.Play();
            correct.Play();
            clearColors();
            //particles.SetActive(true);
            //StartCoroutine(Pause());
            //particleSys.Stop();
            //particles.SetActive(false);
            changeWords();
        }
        else {
            incorrect.Play();
            ans1.color = Color.red;
        }
    }

    public void btn2Clicked() {
        if (ans2.text == word.everyoneWords[sel]) {
            particleSys.Play();
            correct.Play();
            clearColors();
            changeWords();
        }
        else if (everyone == false && ans2.text == word.youngWords[sel]) {
            particleSys.Play();
            correct.Play();
            clearColors();
            //particles.SetActive(true);
            //StartCoroutine(Pause());
            //particleSys.Stop();
            //particles.SetActive(false);
            changeWords();
        }
        else {
            incorrect.Play();
            ans2.color = Color.red;
        }
    }

    public void btn3Clicked() {
        if (ans3.text == word.everyoneWords[sel]) {
            particleSys.Play();
            correct.Play();
            clearColors();
            changeWords();
        }
        else if (everyone == false && ans3.text == word.youngWords[sel]) {
            particleSys.Play();
            correct.Play();
            clearColors();
            //particles.SetActive(true);
            //StartCoroutine(Pause());
            //particleSys.Stop();
            //particles.SetActive(false);
            changeWords();
        }
        else {
            incorrect.Play();
            ans3.color = Color.red;
        }
    }

    // IEnumerator Pause()
    // {
    //     Debug.Log("hi");
    //     //print(Time.time);
    //     yield return new WaitForSeconds(2);
    //     Debug.Log("bye");
    //     //print(Time.time);
    // }

    private void clearColors() {
        ans1.color = Color.black;
        ans2.color = Color.black;
        ans3.color = Color.black;
    }

    private int getNewChoice(int[] sel, int len) {
        int c = sel[0]; // 

        while (sel.Contains(c)) {
            c = Random.Range(0, len);
        }
        return c;
    }

    private void changeWords() {
        // just for everyone now
        if (everyone) {
            sel = Random.Range(0, p.paragraph.Length);
            para.text = p.paragraph[sel];

             int[] choices = new int[3];
             choices[0] = sel;
             choices[1] = getNewChoice(choices, p.paragraph.Length);
             choices[2] = getNewChoice(choices, p.paragraph.Length);

            //Random random = new Random();
            //Enumerable.Range(0, 2).OrderBy(c => random.Next()).ToArray();
            //choices = choices.OrderBy(x => random.Next()).ToArray();
            int curr1 = Random.Range(0, 3);
            ans1.text = word.everyoneWords[choices[curr1]];

            int curr2 = curr1;
            while (curr2 == curr1) {
                curr2 = Random.Range(0, 3);
            }

            //int curr1 = (curr == 0) ? 1 : 0;
            ans2.text = word.everyoneWords[choices[curr2]];

            int curr3 = curr2;
            while (curr3 == curr1 || curr3 == curr2) {
                curr3 = Random.Range(0, 3);
            }

            
            ans3.text = word.everyoneWords[choices[curr3]];
            Debug.Log("choices " + choices[0] + choices[1] + choices[2]);

            // int[] choices = p.answers[sel];

            // random numbers, one is the right answer
            // ans1.text = word.everyoneWords[choices[0]];
            // ans2.text = word.everyoneWords[choices[1]];
            // ans3.text = word.everyoneWords[choices[2]];
        }
        else {
            sel = Random.Range(0, p.paragraphY.Length);
            para.text = p.paragraphY[sel];
            Debug.Log("choice " + sel + word.youngWords[sel]);
            
            int[] choices = new int[3];
            choices[0] = sel;
            choices[1] = getNewChoice(choices, p.paragraphY.Length);
            choices[2] = getNewChoice(choices, p.paragraphY.Length);

            //Random random = new Random();
            //Enumerable.Range(0, 2).OrderBy(c => random.Next()).ToArray();
            //choices = choices.OrderBy(x => random.Next()).ToArray();
            int curr1 = Random.Range(0, 3);
            ans1.text = word.youngWords[choices[curr1]];

            int curr2 = curr1;
            while (curr2 == curr1) {
                curr2 = Random.Range(0, 3);
            }

            //int curr1 = (curr == 0) ? 1 : 0;
            ans2.text = word.youngWords[choices[curr2]];

            int curr3 = curr2;
            while (curr3 == curr1 || curr3 == curr2) {
                curr3 = Random.Range(0, 3);
            }

            
            ans3.text = word.youngWords[choices[curr3]];
        }
    }
}

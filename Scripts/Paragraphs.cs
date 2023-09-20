using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paragraphs : MonoBehaviour
{
    public string[] paragraph = {"\"Hey honey! How was your day?\"\n\"Alright but I'm starving. What are we having for dinner?\"\n\"I don't know. Can we get delivery? I don't think I can cook today.\"\n\"Sure. It's been a long day for me too. _ _\"",
"\"How did your date with John go last night?\"\n\"Ok I guess. I liked him a lot but honestly he chewed with his mouth open the whole dinner and it was _ _ _. I'm not sure if we'll go out again.\"",
"\"What season of Is It Cake? are you on? You've been watching that show all day. You are such a _ _.\"",
"\"I want to introduce you to my friend Amy. She went to law school like you.\"\n\"Hi, _ _. I'm Enrique.\"",
"\"Do you want to hang out tonight?\"\n\"Yeah I can but is it ok if we just _? I don't have a lot of energy.\"",
"\"I went to the bar, but it was _ so I decided to leave.\"",
"\"_ politics have really changed the way the way people talk there.\""};

    public int[][] answers = new int[][] { new int[] {0, 1, 4}, 
        new int[] {3, 1, 2}};

    public string[] paragraphY = {"\"What is that music?\"\n\"Oh, it's something that my mom bought me. Just checking it out.\"\n\"_\"",
        "\"You can't do her laundry for her. She's not even your girlfriend. You're being such a _.\""};
    public int[][] answersY = new int[][] { new int[] {0, 1, 2},
        new int[] {0, 1, 2}};
}

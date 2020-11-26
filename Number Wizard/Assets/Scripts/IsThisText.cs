using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

using System;

public class IsThisText : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI isThis;
    string[] isThisAnswers = new string[] { "I'am sure this is", "Well, then it must be",
                                            "Are you kidding with me?", "Ok, let's fucking play",
                                            "It's time to real guesses", "I guess you like humiliation",
                                            "Isn't that right, prick?", "What, are you crying?",
                                            "You cry often, I guess", "Wait, I know something...",
                                            "Oh no, but it seems that...", "You're also a liar"};
    int currentIsThisAnswer = 0;

    void Start()
    {
        ChangeIsThisText();
    }

    public void ChangeIsThisText()
    {
        isThis.SetText(isThisAnswers[currentIsThisAnswer++]);
        currentIsThisAnswer = Math.Min(currentIsThisAnswer, isThisAnswers.Length - 1);
    }
}

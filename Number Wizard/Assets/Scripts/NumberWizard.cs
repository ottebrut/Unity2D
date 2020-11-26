using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int min = 1;
    [SerializeField] int max = 1000;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;

    void Start()
    {
        UpdateGuess();
    }

    private void UpdateGuess()
    {
        guess = (min + max) / 2;
        guessText.SetText(guess.ToString());
    }

    public void OnPressHigher()
    {
        min = guess + 1;
        UpdateGuess();
    }

    public void OnPressLower()
    {
        max = guess - 1;
        UpdateGuess();
    }
}

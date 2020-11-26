using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HowToPlay : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI logo;
    [SerializeField] TextMeshProUGUI howToPlay;

    void Start()
    {
        howToPlay.enabled = false;
    }

    public void ToggleInstruction()
    {
        logo.enabled = !logo.enabled;
        howToPlay.enabled = !howToPlay.enabled;
    }
}

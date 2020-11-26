using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    [TextArea(10, 40)] [SerializeField] string storyText;
    [SerializeField] State[] nextStates;

    public string GetStoryText()
    {
        return storyText;
    }

    public State[] GetNextStates()
    {
        return nextStates;
    }
}

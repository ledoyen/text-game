using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class State : ScriptableObject
{
    [TextArea(10, 14)] [SerializeField] string storyText;
    [SerializeField] NextState[] nextStates;

    public string GetStateStory()
    {
        return storyText;
    }

    public NextState[] GetNextStates()
    {
        return nextStates;
    }

    [System.Serializable]
    public class NextState
    {
        public string choiceSentence;
        public State state;
    }
}

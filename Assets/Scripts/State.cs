using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    [SerializeField]
    [TextArea(10, 14)]
    private string storyText;
    public string StoryText
    {
        get => storyText;
        set => storyText = value;
    }

    [SerializeField]
    private State[] nextStates;
    public State[] NextStates { get => nextStates; }
}

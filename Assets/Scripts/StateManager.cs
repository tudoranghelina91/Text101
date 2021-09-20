using UnityEngine;

public class StateManager
{
    private readonly AdventureGame _adventureGame;
    
    public StateManager(AdventureGame adventureGame)
    {
        this._adventureGame = adventureGame;
        this.SetState(adventureGame.State);
    }

    private void SetState(State state)
    {
        this._adventureGame.State = state;
        this._adventureGame.TextComponent.text = state.StoryText;
    }

    public void HandleStates(int option)
    {
        if (option >= 0 && _adventureGame.State.NextStates.Length - option > 0)
        {
            this.SetState(_adventureGame.State.NextStates[option]);
        }
    }


}

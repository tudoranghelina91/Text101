using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField]
    private Text textComponent;
    public Text TextComponent
    {
        get => textComponent;
        set => textComponent = value;
    }

    [SerializeField]
    private State state;
    public State State 
    { 
        get => state;
        set => state = value;
    }

    private StateManager _stateManager;
    private InputHandler _inputHandler;

    // Start is called before the first frame update
    void Start()
    {
        this._stateManager = new StateManager(this);
        this._inputHandler = new InputHandler();
    }

    // Update is called once per frame
    void Update()
    {
        _stateManager.HandleStates(_inputHandler.GetOptionByKey());
    }
}

using UnityEngine;

public class GameEventOpts
{
    public IState _newState;
    public IState _previousState;
    public int _moneyEarned;
    
    public GameEventOpts()
    {
    }

    public GameEventOpts(IState previousState, IState newState)
    {
        _previousState = previousState;
        _newState = newState;
    }

    public IState PreviousState()
    {
        return _previousState;
    }

    public IState NewState()
    {
        return _newState;
    }
}

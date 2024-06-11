using System;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public class UnityEventGame : UnityEvent<GameEventOpts>
{
}

public class GameEventListener : GameEventListenerBase
{
    [SerializeField]
    protected UnityEventGame _unityEventGame;

    public void RaiseEvent(GameEventOpts opts)
    {
        _unityEvent?.Invoke();
        _unityEventGame?.Invoke(opts);
    }
}
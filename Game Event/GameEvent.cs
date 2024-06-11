using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Game Event", fileName = "New Game Event")]
public class GameEvent : GameEventBase
{
    public void Invoke(GameEventOpts opts)
    {
        if (_debug && Application.isPlaying)
            Debug.Log($"GameEvent: Invoked GameEvent listeners: num_listeners({_listeners.Values.Count})");

        foreach (KeyValuePair<int, GameEventListenerBase> listener in _listeners)
        {
            if (_debug && Application.isPlaying)
                Debug.Log($"GameEvent: RaiseEvent GameEvent listener: name({listener.Value.gameObject.name})",
                    listener.Value.gameObject);
            (listener.Value as GameEventListener).RaiseEvent(opts);
        }
    }
}
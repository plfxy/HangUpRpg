using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameFramework;

public class EventManager {
	private static EventManager eventManger;
    private EventPool<BaseEventArgs> eventPool;

    private EventManager() {
        eventPool = new EventPool<BaseEventArgs>();
    }

    public EventManager GetInstance()
    {
        if (eventManger == null)
        {
            eventManger = new EventManager();
        }
        return eventManger;
    }

}

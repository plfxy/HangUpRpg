using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace WindyFramework.Event
{
    public class EventManager : FrameworkModule
    {
        private Dictionary<EventsId, EventHandler<EventArgs>> _eventHandlers;

        public EventManager()
        {
            _eventHandlers = new Dictionary<EventsId, EventHandler<EventArgs>>();
        }

        public void Subscribe(EventsId eventId, EventHandler<EventArgs> handler)
        {
            EventHandler<EventArgs> eventHandler;
            if (_eventHandlers.TryGetValue(eventId, out eventHandler))
            {
                _eventHandlers[eventId] += handler;
            }
            else
            {
                _eventHandlers.Add(eventId, handler);
            }
        }

        public void Fire(EventsId eventId, object sender, EventArgs eventArgs)
        {
            EventHandler<EventArgs> eventHandler;
            if (_eventHandlers.TryGetValue(eventId, out eventHandler))
            {
                if (eventHandler != null)
                {
                    eventHandler(sender, eventArgs);
                }
                else
                {
                    Debug.LogError("EventHandler for event " + eventId + "  is null");
                }
                
            }
        }
    }
}


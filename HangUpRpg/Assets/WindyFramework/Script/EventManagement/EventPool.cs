using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameFramework;

public class EventPool<T> where T : BaseEventArgs
{
    private Dictionary<int, LinkedList<EventHandler<T>>> m_EventHandlers;

    public EventPool()
    {
        m_EventHandlers = new Dictionary<int, LinkedList<EventHandler<T>>>();
    }

    public void Subscribe(int id, EventHandler<T> handler)
    {
        LinkedList<EventHandler<T>> handlers = null;
        if (handler == null)
        {
            throw new Exception("Event handler is invalid.");
        }
        if (!m_EventHandlers.TryGetValue(id,out handlers))
        {
            handlers = new LinkedList<EventHandler<T>>();
            handlers.AddLast(handler);
            m_EventHandlers.Add(id, handlers);
        }
        else
        {
            handlers.AddLast(handler);
        }
    }

    public void Fire(object sender, T e)
    {
        LinkedList<EventHandler<T>> handlers;
        if (m_EventHandlers.TryGetValue(e.Id,out handlers) && handlers.Count>0)
        {
            LinkedListNode<EventHandler<T>> current;
            current = handlers.First;
            while (current != null)
            {
                LinkedListNode<EventHandler<T>> next = current.Next;
                current.Value(sender, e);
                current = next;
            }
        }
    }
}

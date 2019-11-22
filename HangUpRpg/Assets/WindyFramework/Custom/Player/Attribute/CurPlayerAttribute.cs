using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WindyFramework.Event;
using System;

namespace WindyFramework.Player
{
    public class CurPlayerAttribute : PlayerAttribute
    {
        private EventManager IEventManager
        {
            get
            {
                if (_IEventManager == null)
                {
                    _IEventManager = FrameworkEntry.GetComponent<EventManager>();
                }
                return _IEventManager;
            }
        }
        EventManager _IEventManager;

        public override int Strength
        {
            get
            {
                return _Strength;
            }
            protected set
            {
                if (_Strength != value)
                {
                    _Strength = value;
                    IEventManager.Fire(EventsId.PLAYER_STRENGTH_CHANGE, this, EventArgs.Empty);
                }
            }
        }
        private int _Strength;

        public CurPlayerAttribute():base()
        {
        }
    }
}

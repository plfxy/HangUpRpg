using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WindyFramework.Event;
using System;

namespace WindyFramework.Player
{
    public class PlayerManager : FrameworkModule
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

        public string NickName
        {
            get
            {
                return _NickName;
            }
            set
            {
                _NickName = value;
                IEventManager.Fire(EventsId.PLAYER_NAME_CHANGE, this, EventArgs.Empty);
            }
        }
        private string _NickName;

        public int Strength
        {
            get
            {
                return _Strength;
            }
            set
            {
                _Strength = value;
                IEventManager.Fire(EventsId.PLAYER_STRENGTH_CHANGE, this, EventArgs.Empty);
            }
        }
        private int _Strength;

        public int Lv {
            get
            {
                return _Lv;
            }
            set
            {
                _Lv = value;
                IEventManager.Fire(EventsId.PLAYER_LEVEL_CHANGE, this, EventArgs.Empty);
            }
        }
        private int _Lv;

        public  PlayerManager()
        {
            NickName = "Windy";
            Lv = 4;
            Strength = 1265;
        }
    }
}


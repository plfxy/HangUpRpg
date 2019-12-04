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

        public CurPlayerAttribute curPlayerAttribute;
        public PlayerEquipManager playerEquipManger;
        public PlayerLevelManager playerLevelManager;
        public PlayerStageInfoManager playerStageInfoManager;

        public  PlayerManager()
        {
            NickName = "Windy";
            curPlayerAttribute = new CurPlayerAttribute();
            playerEquipManger = new PlayerEquipManager(curPlayerAttribute);
            playerLevelManager = new PlayerLevelManager(curPlayerAttribute);
            playerStageInfoManager = new PlayerStageInfoManager();
        }
    }
}

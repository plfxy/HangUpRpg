using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WindyFramework.Event;
using WindyFramework.Data;
using System;

namespace WindyFramework.Player
{
    public class PlayerLevelManager: IPlayerAttributeDecorater
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

        private CurPlayerAttribute _curPlayerAttribute;

        private ADataSheet<PropertyLevelDataRow> PropertyLevel
        {
            get
            {
                if (_propertyLevel == null)
                    _propertyLevel = FrameworkEntry.GetComponent<DataManager>().GetDataSheet<PropertyLevelDataRow>("PropertyLevel");
                return _propertyLevel;
            }
        }
        private ADataSheet<PropertyLevelDataRow> _propertyLevel;

        public int Lv
        {
            get
            {
                return _lv;
            }
            private set
            {
                _lv = value;
                IEventManager.Fire(EventsId.PLAYER_LEVEL_CHANGE, this, EventArgs.Empty);
            }
        }
        private int _lv;

        public int Exp
        {
            get
            {
                return _exp;
            }
        }
        private int _exp;
        private int _expForNextLv = 5;

        public int PropertyLv
        {
            get
            {
                return _propertylv;
            }
            private set
            {
                _propertylv = value;
                CurPropertyLevelData = PropertyLevel.GetDataRowById(PropertyLv);
            }
        }
        private int _propertylv;

        private PropertyLevelDataRow CurPropertyLevelData
        {
            get
            {
                return _curPropertyLevelData;
            }
            set
            {
                if (_curPropertyLevelData != null)
                {
                    UnloadDecorater(_curPlayerAttribute);
                }
                _curPropertyLevelData = value;
                _propertyExpForNextLv = _curPropertyLevelData.Exp;
                LoadDecorater(_curPlayerAttribute);
            }
        }
        private PropertyLevelDataRow _curPropertyLevelData;

        public int PropertyExp
        {
            get
            {
                return _propertyExp;
            }
        }
        private int _propertyExp;
        private int _propertyExpForNextLv;

        public PlayerLevelManager(CurPlayerAttribute curPlayerAttribute)
        {
            _curPlayerAttribute = curPlayerAttribute;
            Lv = 1;            
            PropertyLv = 1;
        }

        public void AddExp(int exp)
        {
            _exp += exp;
            while (_exp >= _expForNextLv)
            {
                _exp -= _expForNextLv;
                Lv = Lv + 1;
            }
        }

        public void AddPropertyExp(int propertyExp)
        {
            _propertyExp += propertyExp;
            while (_propertyExp >= _propertyExpForNextLv)
            {
                _propertyExp -= _propertyExpForNextLv;
                PropertyLv += 1;
            }
        }

        public void LoadDecorater(PlayerAttribute curPlayerAttribute)
        {
            curPlayerAttribute.StrengthModifier += CurPropertyLevelData.Property;
        }

        public void UnloadDecorater(PlayerAttribute curPlayerAttribute)
        {
            curPlayerAttribute.StrengthModifier -= CurPropertyLevelData.Property;
        }
    }
}

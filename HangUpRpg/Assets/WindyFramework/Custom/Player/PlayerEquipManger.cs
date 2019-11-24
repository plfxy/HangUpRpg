using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WindyFramework.Equip;
using WindyFramework.Event;
using System;

namespace WindyFramework.Player
{
    public class PlayerEquipManager
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

        private Equip.Equip[] equipList;

        public PlayerEquipManager(CurPlayerAttribute curPlayerAttribute)
        {
            _curPlayerAttribute = curPlayerAttribute;
            equipList = new Equip.Equip[EquipType.EquipTypeNum + 1];
            Debug.Log("Equip List's Length is " + EquipType.EquipTypeNum);
            #region 临时代码，初始化玩家装备
            EquipEquipment(1101);
            EquipEquipment(1201);
            EquipEquipment(1301);
            EquipEquipment(1401);
            EquipEquipment(1501);
            EquipEquipment(1601);
            EquipEquipment(1701);
            EquipEquipment(1801);
            #endregion
        }

        public void EquipEquipment(int equipId)
        {
            Equip.Equip equip;
            int equipPosition;

            equip = new Equip.Equip(equipId);
            equipPosition = equip.Postion-1;
            Debug.Log("Equip postion: " + equipPosition + "is about to change");
            if (equipList[equipPosition] != null)
            {
                equipList[equipPosition].UnloadDecorater(_curPlayerAttribute);
            }
            equipList[equipPosition] = equip;
            equipList[equipPosition].LoadDecorater(_curPlayerAttribute);
        }
    }
}


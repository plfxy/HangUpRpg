using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace WindyFramework.Equip
{
    public static class EquipType
    {
        public static int EquipTypeNum
        {
            get
            {
               if (_equipTypeNum ==-1)
                {
                    foreach (int i in Enum.GetValues(typeof(EquipTypes)))
                    {
                        if (i > _equipTypeNum) _equipTypeNum = i;
                    }
                }
                return _equipTypeNum;
            }
        }
        private static int _equipTypeNum = -1;

        public enum EquipTypes
        {
            MAIN_WEAPON,
            SUB_WEAPON,
            CLOTHES,
            RING,
            SHOES,
            CLOAK,
            BRACELET,
            BELT
        }

    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WindyFramework.Player;
using WindyFramework.Data;

namespace WindyFramework.Equip
{
    public class Equip:IPlayerAttributeDecorater
    {
        public int Id
        {
            get;
            protected set;
        }

        public int LevelLimit
        {
            get;
            protected set;
        }

        public int Postion
        {
            get;
            protected set;
        }

        public int Rarity
        {
            get;
            protected set;
        }

        public int Name
        {
            get;
            protected set;
        }

        public int Strength
        {
            get;
            protected set;
        }

        public Equip(int equipId)
        {
            ADataSheet<EquipDataRow> equipDataSheet;
            EquipDataRow equipDataRow;

            equipDataSheet = FrameworkEntry.GetComponent<DataManager>().GetDataSheet<EquipDataRow>("Equip");
            equipDataRow = equipDataSheet.GetDataRowById(equipId);
            Id = equipId;
            LevelLimit = equipDataRow.LevelLimit;
            Postion = equipDataRow.Postion;
            Rarity = equipDataRow.Rarity;
            Name = equipDataRow.Name;
            Strength = equipDataRow.Strength;
        }

        public void LoadDecorater(PlayerAttribute playerAttribute)
        {
            playerAttribute.StrengthBase += Strength;
        }
        public void UnloadDecorater(PlayerAttribute playerAttribute)
        {
            playerAttribute.StrengthBase -= Strength;
        }
    }
}


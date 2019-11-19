using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using WindyFramework.Data;

namespace WindyFramework.Data
{
    public class EquipDataRow : ADataRow
    {
        public int Name { get; private set; }
        public int LevelLimit { get; private set; }
        public int Postion { get; private set; }
        public int Rarity { get; private set; }
        public int Strength { get; private set; }

        public override void ParseData(DataHolder dataHolder)
        {
            dataHolder.ResetIndex();
            Id = int.Parse(dataHolder.GetData());
            Name = int.Parse(dataHolder.GetData());
            LevelLimit = int.Parse(dataHolder.GetData());
            Postion = int.Parse(dataHolder.GetData());
            Rarity = int.Parse(dataHolder.GetData());
            Strength = int.Parse(dataHolder.GetData());
        }
    }
}


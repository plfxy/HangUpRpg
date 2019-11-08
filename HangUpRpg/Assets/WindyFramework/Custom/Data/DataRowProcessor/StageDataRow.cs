using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using WindyFramework.Data;

namespace WindyFramework.Data
{
    public class StageDataRow : ADataRow
    {
        public int Strength { get; private set; }
        public int Reward { get; private set; }

        public override void ParseData(DataHolder dataHolder)
        {
            dataHolder.ResetIndex();
            Id = int.Parse(dataHolder.GetData());
            Strength = int.Parse(dataHolder.GetData());
            Reward = int.Parse(dataHolder.GetData());
        }
    }
}


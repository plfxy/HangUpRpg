using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using WindyFramework.Data;

namespace WindyFramework.Data
{
    public class RewardDataRow : ADataRow
    {
        public int Mode { get; private set; }
        public string Reward { get; private set; }

        public override void ParseData(DataHolder dataHolder)
        {
            dataHolder.ResetIndex();
            Id = int.Parse(dataHolder.GetData());
            Mode = int.Parse(dataHolder.GetData());
            Reward = dataHolder.GetData();
        }
    }
}


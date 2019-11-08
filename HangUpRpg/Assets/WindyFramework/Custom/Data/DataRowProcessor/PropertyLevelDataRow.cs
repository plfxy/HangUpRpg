using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using WindyFramework.Data;

namespace WindyFramework.Data
{
    public class PropertyLevelDataRow : ADataRow
    {
        public float Property { get; private set; }
        public int Exp { get; private set; }

        public override void ParseData(DataHolder dataHolder)
        {
            dataHolder.ResetIndex();
            Id = int.Parse(dataHolder.GetData());
            Property = float.Parse(dataHolder.GetData());
            Exp = int.Parse(dataHolder.GetData());
        }
    }
}


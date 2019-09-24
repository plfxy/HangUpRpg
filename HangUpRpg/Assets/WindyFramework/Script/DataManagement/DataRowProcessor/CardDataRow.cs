using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDataRow : ADataRow {

    public int Rarity { get;private set; }
    public int Num { get;private set; }

	public override void ParseData(DataHolder dataHolder)
    {
        dataHolder.ResetIndex();
        Id = int.Parse(dataHolder.GetData());
        Rarity = int.Parse(dataHolder.GetData());
        Num = int.Parse(dataHolder.GetData());
    }
}

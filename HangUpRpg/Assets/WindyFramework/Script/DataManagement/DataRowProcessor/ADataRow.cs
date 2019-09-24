using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ADataRow {
    public int Id { get; protected set; }

    public virtual void ParseData(DataHolder dataHoder) { }

}

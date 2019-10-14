using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WindyFramework.Data
{
    public abstract class ADataRow
    {
        public int Id { get; protected set; }

        public virtual void ParseData(DataHolder dataHoder) { }

    }
}


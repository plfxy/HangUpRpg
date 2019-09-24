using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataHolder {
    private string[] data;
    private int Index { get; set; }
    
    public DataHolder(string sData)
    {
        data = sData.Split(new char[] { '\t' });
        Index = 0;
    }

    public string GetData()
    {
        string getData;
        if (Index < data.Length - 1)
        {
            getData = data[Index];
            Index++;
        }
        else
        {
            getData = null;
        }
        return getData;
    }

    public void ResetIndex()
    {
        Index = 1;
    }

}

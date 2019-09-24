using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ADataSheet<T> where T:ADataRow, new()
{
    private List<T> dataList;
    T t = new T();

    public ADataSheet(string strData)
    {
        dataList = new List<T>();
        string[] arrData = strData.Split(new char[] { '\n' });
        for (int i = 4; i < arrData.Length; i++)
        {
            t.ParseData(new DataHolder(arrData[i]));
            dataList.Add(t);
        }
    }

    public T GetDataRowById(int id)
    {
        return dataList[0];
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WindyFramework.Data
{
    public class ADataSheet<T>:IDataSheet where T : ADataRow, new()
    {
        private List<T> dataList;

        public string DataSheetName
        {
            get
            {
                return _dataSheetName;
            }
        }
        private string _dataSheetName;


        public ADataSheet(string dataSheetName,string strData)
        {
            _dataSheetName = dataSheetName;
            dataList = new List<T>();
            string[] arrData = strData.Split(new char[] { '\n' });
            for (int i = 4; i < arrData.Length; i++)
            {
                T t;
                t = new T();
                t.ParseData(new DataHolder(arrData[i]));
                dataList.Add(t);
            }
        }

        public T GetDataRowById(int id)
        {
            foreach (T dataRow in dataList)
            {
                if (dataRow.Id == id) return dataRow;
            }
            Debug.LogError("Can't get id=" + id + "in" + DataSheetName);
            return null;
        }

        public T GetLastDataRow()
        {
            return dataList[dataList.Count-1];
        }
    }
}


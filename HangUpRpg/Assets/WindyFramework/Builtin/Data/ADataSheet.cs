using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WindyFramework.Data
{
    public class ADataSheet<T>:IDataSheet where T : ADataRow, new()
    {
        private List<T> dataList;
        T t = new T();

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
                t.ParseData(new DataHolder(arrData[i]));
                dataList.Add(t);
            }
        }

        public T GetDataRowById(int id)
        {
            return dataList[0];
        }
    }
}


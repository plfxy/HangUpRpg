using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace WindyFramework.Data
{
    public class DataManager : FrameworkModule
    {
        private static string _dataFolderPath = null;
        private List<IDataSheet> _dataSheetList=new List<IDataSheet>();

        public DataManager()
        {
            _dataFolderPath = Path.Combine(Application.dataPath, "WindyFramework");
            _dataFolderPath = Path.Combine(_dataFolderPath, "Custom");
            _dataFolderPath = Path.Combine(_dataFolderPath, "Data");
            _dataFolderPath = Path.Combine(_dataFolderPath, "DataTable");
        }

        private ADataSheet<T> LoadDataSheet<T>(string dataSheetName) where T : ADataRow, new()
        {
            string dataTablePath;
            ADataSheet<T> aDataSheet;

            dataTablePath = Path.Combine(_dataFolderPath, dataSheetName + ".csv");
            using (FileStream fs = new FileStream(dataTablePath, FileMode.Open, FileAccess.Read))
            {
                long fsLen = fs.Length;
                byte[] heByte = new byte[fsLen];
                fs.Read(heByte, 0, heByte.Length);
                string strData = System.Text.Encoding.UTF8.GetString(heByte);
                aDataSheet = new ADataSheet<T>(dataSheetName, strData);
            }
            return aDataSheet;
        }

        public bool IsSheetLoaded(string dataSheetName)
        {
            foreach (IDataSheet dataSheet in _dataSheetList)
            {
                if (dataSheet.DataSheetName == dataSheetName)
                    return true;
            }
            return false;
        }

        public ADataSheet<T> GetDataSheet<T>(string dataSheetName) where T : ADataRow,new()
        {
            if (IsSheetLoaded(dataSheetName))
            {
                foreach (IDataSheet dataSheet in _dataSheetList)
                {
                    if (dataSheet.DataSheetName == dataSheetName)
                        return dataSheet as ADataSheet<T>;
                }
            }
            else
            {
                _dataSheetList.Add(LoadDataSheet<T>(dataSheetName));
                return _dataSheetList[_dataSheetList.Count] as ADataSheet<T>;
            }
            return null;
        }
    }
}

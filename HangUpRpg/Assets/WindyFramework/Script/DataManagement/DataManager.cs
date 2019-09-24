using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataManager {
    private static DataManager dataManager;

    private DataManager() { }

    public static DataManager GetInstance()
    {
        if (dataManager == null)
        {
            dataManager = new DataManager();
        }
        return dataManager;
    }

    public ADataSheet<T> LoadDataSheet<T>(string dataSheetName) where T:ADataRow,new()
    {
        string path;
        ADataSheet<T> aDataSheet;

        path = Path.Combine(Application.dataPath, "WindyFramework");
        path = Path.Combine(path, "Data");
        path = Path.Combine(path, dataSheetName + ".csv");
        using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
        {
            long fsLen = fs.Length;
            byte[] heByte = new byte[fsLen];
            int r = fs.Read(heByte, 0, heByte.Length);
            string strData = System.Text.Encoding.UTF8.GetString(heByte);
            aDataSheet = new ADataSheet<T>(strData);
        }
        return aDataSheet;
    }
}

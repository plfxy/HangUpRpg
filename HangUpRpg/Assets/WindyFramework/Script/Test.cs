using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour {
    void Start()
    {
        DataManager dataManager = DataManager.GetInstance();
        ADataSheet<CardDataRow> cardSheet = dataManager.LoadDataSheet<CardDataRow>("Card");
        Debug.LogError(cardSheet.GetDataRowById(1).Num);
    }
}

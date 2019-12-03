using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WindyFramework.Data;

public class MonsterInfoHandler
{
    public int CurMonsterLevel
    {
        get
        {
            return _curMonsterLevel;
        }
        set
        {
            _curMonsterLevel = value;
            UpdateStageInfo();
        }
    }
    private int _curMonsterLevel;

    private DataManager dataManager;
    private ADataSheet<StageDataRow> stageDataSheet;
    private TMPro.TextMeshPro stageInfo;
    private TMPro.TextMeshPro monsterStrength;

    public void Start()
    {
        Camera mainCamera = Camera.main;
        stageInfo = mainCamera.transform.Find("MainScene").Find("StageInfo").GetComponent<TMPro.TextMeshPro>();
        monsterStrength = mainCamera.transform.Find("MainScene").Find("Monster").Find("MonsterStrength").Find("StrengthValue").GetComponent<TMPro.TextMeshPro>();
        dataManager = WindyFramework.FrameworkEntry.GetComponent<DataManager>();
        stageDataSheet = dataManager.GetDataSheet<StageDataRow>("Stage");
        CurMonsterLevel = 10;
    }

    public void UpdateStageInfo()
    {
        stageInfo.text = "Layer " + CurMonsterLevel;
        monsterStrength.text = "Strength " + stageDataSheet.GetDataRowById(CurMonsterLevel).Strength.ToString();
    }


}

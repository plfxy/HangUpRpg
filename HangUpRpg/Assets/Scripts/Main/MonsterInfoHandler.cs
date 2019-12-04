using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WindyFramework.Data;
using WindyFramework.Player;

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
            if (value>0 && value <= playerStageInfoManager.UnlockStage)
            {
                _curMonsterLevel = value;
                UpdateStageInfo();
            }
        }
    }
    private int _curMonsterLevel;

    private PlayerStageInfoManager playerStageInfoManager;
    private ADataSheet<StageDataRow> stageDataSheet;
    private TMPro.TextMeshPro stageInfo;
    private TMPro.TextMeshPro monsterStrength;

    public void Start()
    {
        Camera mainCamera = Camera.main;
        DataManager dataManager;
        dataManager = WindyFramework.FrameworkEntry.GetComponent<DataManager>();
        stageDataSheet = dataManager.GetDataSheet<StageDataRow>("Stage");
        PlayerManager playerManager;
        playerManager = WindyFramework.FrameworkEntry.GetComponent<PlayerManager>();
        playerStageInfoManager = playerManager.playerStageInfoManager;
        stageInfo = mainCamera.transform.Find("MainScene").Find("StageInfo").GetComponent<TMPro.TextMeshPro>();
        monsterStrength = mainCamera.transform.Find("MainScene").Find("Monster").Find("MonsterStrength").Find("StrengthValue").GetComponent<TMPro.TextMeshPro>();
        CurMonsterLevel = 10;
    }

    public void UpdateStageInfo()
    {
        stageInfo.text = "Layer " + CurMonsterLevel;
        monsterStrength.text = "Strength " + stageDataSheet.GetDataRowById(CurMonsterLevel).Strength.ToString();
    }


}

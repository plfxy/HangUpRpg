using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WindyFramework.Data;
using WindyFramework.Event;
using System;

namespace WindyFramework.Player
{
    public class PlayerStageInfoManager 
    {
        private ADataSheet<StageDataRow> stageDataTable;
        private EventManager eventManager;

        public int UnlockStage
        {
            get
            {
                return _unlockStage;
            }
            private set
            {
                if (value > _unlockStage)
                {
                    _unlockStage = value;
                    eventManager.Fire(EventsId.STAGE_UNLOCKED, this, EventArgs.Empty);
                }
                else
                {
                    Debug.LogError("Try to unlock stage which is already unlocked!");
                }
                
            }
        }
        private int _unlockStage;

        public void StageClear(int stageId)
        {
            if (stageId > UnlockStage)
            {
                Debug.LogError("Try to skip stage!");
            }
            else if (stageId == UnlockStage)
            {
                if (stageId + 1 <= stageDataTable.GetLastDataRow().Id)
                    UnlockStage = stageId + 1;
            }
        }

        public PlayerStageInfoManager()
        {
            stageDataTable = FrameworkEntry.GetComponent<DataManager>().GetDataSheet<StageDataRow>("Stage");
            eventManager = FrameworkEntry.GetComponent<EventManager>();
            UnlockStage = 40;
        }
    }
}

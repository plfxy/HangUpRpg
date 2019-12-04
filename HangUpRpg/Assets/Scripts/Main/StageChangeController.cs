using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using WindyFramework.Event;
using WindyFramework.Player;

public class StageChangeController : MonoBehaviour
{
    public int nextOrLast;
    private MainSceneManager mainSceneManager;
    private PlayerStageInfoManager playerStageInfoManager;

    void Start()
    {
        mainSceneManager = Camera.main.GetComponent<MainSceneManager>();
        EventManager eventManager = WindyFramework.FrameworkEntry.GetComponent<EventManager>();
        eventManager.Subscribe(EventsId.MOUSE_LEFT_BUTTON_CLICKED, OnClick);
        PlayerManager playerManager = WindyFramework.FrameworkEntry.GetComponent<PlayerManager>();
        playerStageInfoManager = playerManager.playerStageInfoManager;
    }

    void Update()
    {
        SpriteRenderer spriteRenderer;
        spriteRenderer = this.GetComponent<SpriteRenderer>();
        spriteRenderer.enabled = true;
        if (nextOrLast == -1)
        {
            if (mainSceneManager.monsterInfoHandler.CurMonsterLevel == 1)
            {
                spriteRenderer.enabled = false;    
            }
        }
        else if (nextOrLast == 1)
        {
            if (mainSceneManager.monsterInfoHandler.CurMonsterLevel == playerStageInfoManager.UnlockStage)
            {
                spriteRenderer.enabled = false;
            }
        }    

    }

    public void OnClick(object sender, EventArgs eventArgs)
    {
        LeftClickEventArgs leftClickEventArgs = (LeftClickEventArgs) eventArgs;
        if (leftClickEventArgs.ClickedObject == this.transform)
        {
            mainSceneManager.ChangeStage(nextOrLast);
        }
    }
}

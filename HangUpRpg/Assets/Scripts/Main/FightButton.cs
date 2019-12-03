using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WindyFramework.Player;
using WindyFramework.Event;
using System;

public class FightButton : MonoBehaviour
{
    PlayerLevelManager playerLevelManager;

    void Start()
    {
        PlayerManager playerManager;
        playerManager = WindyFramework.FrameworkEntry.GetComponent<PlayerManager>();
        playerLevelManager = playerManager.playerLevelManager;
        EventManager eventManager;
        eventManager = WindyFramework.FrameworkEntry.GetComponent<EventManager>();
        eventManager.Subscribe(EventsId.MOUSE_LEFT_BUTTON_CLICKED, OnClick);
    }

    public void OnClick(object sender, EventArgs eventArgs)
    {
        LeftClickEventArgs leftClickEventArgs;
        leftClickEventArgs = (LeftClickEventArgs)eventArgs;
        if (this.transform == leftClickEventArgs.ClickedObject)
        {
            playerLevelManager.AddExp(100);
        }
    }
}

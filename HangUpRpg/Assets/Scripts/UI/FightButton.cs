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

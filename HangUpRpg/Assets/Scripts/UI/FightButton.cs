using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WindyFramework.Player;

public class FightButton : MonoBehaviour
{
    PlayerLevelManager playerLevelManager;

    void Start()
    {
        PlayerManager playerManager;
        playerManager = WindyFramework.FrameworkEntry.GetComponent<PlayerManager>();
        playerLevelManager = playerManager.playerLevelManager;
    }

    public void OnClick()
    {
        playerLevelManager.AddExp(100);

    }
}

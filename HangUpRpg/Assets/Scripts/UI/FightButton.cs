using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WindyFramework.Player;

public class FightButton : MonoBehaviour
{
    PlayerManager playerManager;
    void Start()
    {
        playerManager = WindyFramework.FrameworkEntry.GetComponent<PlayerManager>();
    }

    public void OnClick()
    {
        playerManager.Lv += 100;

    }
}

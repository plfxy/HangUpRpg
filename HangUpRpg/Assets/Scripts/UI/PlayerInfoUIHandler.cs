using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WindyFramework.Event;
using WindyFramework.Player;

public class PlayerInfoUIHandler : MonoBehaviour
{
    private TMPro.TextMeshPro _nickName;
    private TMPro.TextMeshPro _level;
    private TMPro.TextMeshPro _strength;

    private PlayerManager playerManager
    {
        get
        {
            if (_playerManager == null)
            {
                _playerManager = WindyFramework.FrameworkEntry.GetComponent<PlayerManager>();
            }
            return _playerManager;
        }
    }
    private PlayerManager _playerManager;

    private CurPlayerAttribute curPlayerAttribute
    {
        get
        {
            if (_curPlayerAttribute == null)
            {
                _curPlayerAttribute = playerManager.curPlayerAttribute;
            }
            return _curPlayerAttribute;
        }
    }
    private CurPlayerAttribute _curPlayerAttribute;

    void Start()
    {
        _nickName = this.gameObject.transform.Find("NickName").GetComponent<TMPro.TextMeshPro>();
        _level = this.gameObject.transform.Find("LV").Find("LvValue").GetComponent<TMPro.TextMeshPro>();
        _strength = this.gameObject.transform.Find("Strength").Find("StrengthValue").GetComponent<TMPro.TextMeshPro>();
        _level.text = playerManager.Lv.ToString();
        _nickName.text = playerManager.NickName;
        _strength.text = curPlayerAttribute.Strength.ToString();

        EventManager eventManager = WindyFramework.FrameworkEntry.GetComponent<EventManager>();
        eventManager.Subscribe(EventsId.PLAYER_LEVEL_CHANGE,UpdatePlayerLevel);
        eventManager.Subscribe(EventsId.PLAYER_NAME_CHANGE, UpdateNickName);
        eventManager.Subscribe(EventsId.PLAYER_STRENGTH_CHANGE, UpdateStrength);
    }

    private void UpdatePlayerLevel(object sender, System.EventArgs eventArgs)
    {
        _level.text = playerManager.Lv.ToString();
    }

    private void UpdateNickName(object sender, System.EventArgs eventArgs)
    {
        _nickName.text = playerManager.NickName;
    }

    private void UpdateStrength(object sender, System.EventArgs eventArgs)
    {
        _strength.text = curPlayerAttribute.Strength.ToString();
    }
}

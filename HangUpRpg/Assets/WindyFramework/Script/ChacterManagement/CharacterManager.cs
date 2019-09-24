using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager {
    private static CharacterManager _characterManager;
    public string NickName{
        get {
            return _NickName;
        }
        set {
            _NickName = value;
        }
    }
    private string _NickName;

    public int Strength { get; set; }
    public int Lv { get; set; }
    private CharacterManager()
    {
        NickName = "Windy";
        Lv = 4;
        Strength = 1265;
    }
    public static CharacterManager GetInstant()
    {
        if (_characterManager == null)
        {
            _characterManager = new CharacterManager();
        }
        return _characterManager;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WindyFramework;
using System;

public class GameEntry : MonoBehaviour
{
    private EventHandler<EventArgs> eventHandler;
    // Start is called before the first frame update
    void Start()
    {
        FrameworkEntry.RegisterComponent(new WindyFramework.Data.DataManager());
        FrameworkEntry.RegisterComponent(new WindyFramework.Event.EventManager());
        FrameworkEntry.RegisterComponent(new WindyFramework.Player.PlayerManager());
        UnityEngine.SceneManagement.SceneManager.LoadScene("Main",UnityEngine.SceneManagement.LoadSceneMode.Additive);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

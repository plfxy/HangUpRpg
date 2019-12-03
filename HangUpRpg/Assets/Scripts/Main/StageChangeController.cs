using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using WindyFramework.Event;

public class StageChangeController : MonoBehaviour
{
    public int nextOrLast;
    private MainSceneManager mainSceneManager;

    // Start is called before the first frame update
    void Start()
    {
        mainSceneManager = Camera.main.GetComponent<MainSceneManager>();
        EventManager eventManager = WindyFramework.FrameworkEntry.GetComponent<EventManager>();
        eventManager.Subscribe(EventsId.MOUSE_LEFT_BUTTON_CLICKED, OnClick);
    }

    // Update is called once per frame
    public void OnClick(object sender, EventArgs eventArgs)
    {
        LeftClickEventArgs leftClickEventArgs = (LeftClickEventArgs) eventArgs;
        if (leftClickEventArgs.ClickedObject == this.transform)
        {
            mainSceneManager.ChangeStage(nextOrLast);
        }
    }
}

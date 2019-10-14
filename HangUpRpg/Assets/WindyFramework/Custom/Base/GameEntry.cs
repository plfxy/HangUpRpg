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
    }

    private void TestDataManager()
    {
        WindyFramework.Data.DataManager dataManager;
        dataManager = FrameworkEntry.GetComponent(typeof(WindyFramework.Data.DataManager)) as WindyFramework.Data.DataManager;
        WindyFramework.Data.ADataSheet<WindyFramework.Data.CardDataRow> aDataSheet;
        aDataSheet = dataManager.LoadDataSheet<WindyFramework.Data.CardDataRow>("Card");
        Debug.LogError(aDataSheet.GetDataRowById(1).Num);
    }

    /*private void TestEventManager()
    {
        WindyFramework.Event.EventManager eventManager;
        eventManager = FrameworkEntry.GetComponent(typeof(WindyFramework.Event.EventManager)) as WindyFramework.Event.EventManager;
        eventManager.Subscribe(WindyFramework.Event.EventsId.TestEvent1, Ob2);
        eventManager.Subscribe(WindyFramework.Event.EventsId.TestEvent1, Ob1);
        eventManager.Subscribe(WindyFramework.Event.EventsId.TestEvent1, Ob2);
        eventManager.Fire(WindyFramework.Event.EventsId.TestEvent1,this,EventArgs.Empty);
    }*/

    public void Ob1(object sender,EventArgs eventArgs)
    {
        Debug.LogError(1);        
    }

    public void Ob2(object sender,EventArgs eventArgs)
    {
        Debug.LogError(2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

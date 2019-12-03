using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSceneManager : MonoBehaviour
{
    private MonsterInfoHandler monsterInfoHandler;

    // Start is called before the first frame update
    void Start()
    {
        monsterInfoHandler = new MonsterInfoHandler();
        monsterInfoHandler.Start();
    }

    public void ChangeStage(int stageDiff)
    {
        monsterInfoHandler.CurMonsterLevel += stageDiff;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

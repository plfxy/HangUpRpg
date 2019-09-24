using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfoUpdater:MonoBehaviour {

	// Use this for initialization
	void Start () {
        PlayerNameUpdate();
    }
	
    public void PlayerNameUpdate()
    {
        GameObject nickName = this.gameObject.transform.Find("NickName").gameObject;
        nickName.GetComponent<TMPro.TextMeshPro>().text="1";   
        
    }

	// Update is called once per frame
	void Update () {
        
	}
}

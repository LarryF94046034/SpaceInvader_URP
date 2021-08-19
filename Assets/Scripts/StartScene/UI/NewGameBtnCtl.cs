using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGameBtnCtl : UIBase
{
    public GameObject newGameBtn;
    public string selectLevelSceneName;
    // Start is called before the first frame update
    void Start()
    {
        AddButtonListen(newGameBtn.name,LoadToSelectScene);
    }

    public void LoadToSelectScene()
    {
        UnityAPI_ChangeScene.Instance.LoadSceneWithName(selectLevelSceneName);
    }

}

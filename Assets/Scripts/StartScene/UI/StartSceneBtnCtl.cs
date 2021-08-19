using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSceneBtnCtl : UIBase
{
    public GameObject newGameBtn;
    public GameObject settingBtn;
    public GameObject storeBtn;
    public GameObject quitBtn;

    public string selectLevelSceneName;
    // Start is called before the first frame update
    void Start()
    {
        AddButtonListen(newGameBtn.name,LoadToSelectScene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadToSelectScene()
    {
        UnityAPI_ChangeScene.Instance.LoadSceneWithName(selectLevelSceneName);
    }

    
}

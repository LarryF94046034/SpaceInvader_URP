using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSceneCtl : UIBase
{
    public GameObject changeSceneBtn;
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        AddButtonListen(changeSceneBtn.name,LoadScene);
    }

    public void LoadScene()
    {
        UnityAPI_ChangeScene.Instance.LoadSceneWithName(sceneName);
    }
}

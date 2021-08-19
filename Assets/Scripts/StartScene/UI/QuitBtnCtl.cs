using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitBtnCtl : UIBase
{
    public GameObject quitBtn;
    
    // Start is called before the first frame update
    void Start()
    {
        AddButtonListen(quitBtn.name,QuitGame);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}

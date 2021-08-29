using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSkillCtl : UIBase
{
    public static PlayerSkillCtl Instance;
    //引入
    public GameObject player;
    //邏輯
    [Header("easytouch")]
    public EasyTouchDemoLogic easyTouchDemoLogic;     //Bind,Update
    public string owerImg;
    public string downImg;
    public float moveSpeedMul;
    public float minWidth;
    public float maxWidth;
    public float minHeight;
    public float maxHeight;

    [Header("PlayerBloodLogic")]
    public BloodLogicWithSprite playerBloodLogic;
    public float maxHealth;
    public float maxBloodSpriteWidth;
    public SpriteRenderer playerBloodSpriteRen;
    [Header("Slider:MoveSpeedMul")]
    public Slider moveSpeedSlider;
    

    // Start is called before the first frame update
    void Start()
    {
        Instance=this;

        BindEasyTouchEvent();
        BindPlayerBloodEvent();

        
    }

    // Update is called once per frame
    void Update()
    {
        //EasyTouch
        if(easyTouchDemoLogic!=null)
        {
            easyTouchDemoLogic.Update();
        }
    }
    //EasyTouch
    public void BindEasyTouchEvent()
    {
        //GameObject player=PlayerManager.Instance.GetPlayer.gameObject;
        GameObject downImage=GetWedgate(downImg);
        GameObject tmpOwer=GetWedgate(owerImg);
        easyTouchDemoLogic=new EasyTouchDemoLogic(player,downImage,tmpOwer.transform,moveSpeedMul,minWidth,maxWidth,minHeight,maxHeight);
        AddDrag(tmpOwer.name,easyTouchDemoLogic.OnDrag);
        AddBeginDrag(tmpOwer.name,easyTouchDemoLogic.OnBeginDrag);
        AddEndDrag(tmpOwer.name,easyTouchDemoLogic.OnEndDrag);
        easyTouchDemoLogic.Start();
    }
    public void BindPlayerBloodEvent()
    {
        playerBloodLogic=new BloodLogicWithSprite(playerBloodSpriteRen,maxHealth,0);
    }

    public void SetMoveSpeedMul()
    {
        easyTouchDemoLogic.SetInsideMoveSpeedMul(moveSpeedSlider.value);
    }

}

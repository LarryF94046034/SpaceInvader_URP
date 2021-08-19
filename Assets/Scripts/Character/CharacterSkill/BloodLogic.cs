using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BloodLogicWithSprite
{
    [Header("CharacterTypeID")]
    int characterID;
    [Header("Set")]
    SpriteRenderer characterSprite;
    [Header("Data")]
    float maxWidth;
    float maxHealth;
    float nowHealth;
    [Header("Event")]
    public string eventHeader;
    public event Action dieEvent;
    public BloodLogicWithSprite(SpriteRenderer tmpSprite,float tmpMaxHealth,int tmpCharacterID)
    {
        characterSprite=tmpSprite;
        maxWidth=characterSprite.size.x;  //取得SPRITE最大寬度

        maxHealth=tmpMaxHealth;           //外部取最大血量
        nowHealth=maxHealth;              //內部設定現在血量為最大血量

        characterID=tmpCharacterID;
    }
    float bloodCount=1;
    public void ReduceBlood(float reduce)
    {
        //Debug.Log(reduce);
        nowHealth=nowHealth-reduce;
        if(nowHealth<=0)
        {
            if(characterID==0)
            {
                if(dieEvent!=null)
                {
                    dieEvent();
                }
                
                GameSystems.Instance.gameEventSystem.PlayerDie();
            }
            if(characterID==1)
            {
                if(dieEvent!=null)
                {
                    dieEvent();
                }
                // MonoBehaviour.Destroy(characterSprite.transform.parent.gameObject);
                // MonoBehaviour.Instantiate(GameSystems.Instance.effectSystem.explodeObject,characterSprite.gameObject.transform.position,characterSprite.gameObject.transform.rotation); //在外星人的位置產生爆炸
                // GameFunction.Instance.KillAmount++;
            }
            return;
        }
        characterSprite.size=new Vector2(maxWidth*(nowHealth/maxHealth),characterSprite.size.y);
    }

    // public void Update()
    // {
    //     mySlider.value=bloodCount;
    // }

}

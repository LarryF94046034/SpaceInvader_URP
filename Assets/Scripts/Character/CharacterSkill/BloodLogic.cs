using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodLogicWithSprite
{
    int characterID;
    SpriteRenderer characterSprite;
    float maxWidth;
    float maxHealth;
    float nowHealth;
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
        Debug.Log(reduce);
        nowHealth=nowHealth-reduce;
        if(nowHealth<=0)
        {
            if(characterID==0)
            {
                GameSystems.Instance.gameEventSystem.PlayerDie();
            }
            if(characterID==1)
            {
                MonoBehaviour.Destroy(characterSprite.transform.parent.gameObject);
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

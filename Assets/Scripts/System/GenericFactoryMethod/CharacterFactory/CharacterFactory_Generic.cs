using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterFactory_Generic : TCharacterFactory_Generic
{
    //建立Soldier(Generic版)
    public ISoldier CreateSoldier<T>(ENUM_Weapon emWeapon,int Lv,Vector3 SpawnPosition) where T:ISoldier,new()
    {
        //產生對應T類別
        ISoldier theSoldier=new T();
        if(theSoldier==null)
            return null;
        /*
        //設定模型
        GameObject tmpGameObject =CreateGameObject("CaptainGameObjectName");
        tmpGameObject.gameObject.name="Soldier"+typeof(T).ToString();
        theSoldier.SetGameObject(tmpGameObject);

        //加入武器
        IWeapon Weapon=CreateWeapon(emWeapon);
        theSoldier.SetWeapon(Weapon);

        //取得Soldier數值、設定給角色
        SodierAttr theSoldierAttr=CreateSoldierAttr(theSoldier.GetAttrID());
        theSoldierAttr.SetSoldierLv(Lv);
        theSoldier.SetCharacterAttr(theSoldierAttr);

        //加入AI
        ClothSphereColliderPair theAI=CreateSoldierAI();
        theSoldier.SetAI(theAI);

        //加入管理器
        PBaseDefenseGame.Instance.AddSoldier(theSoldier as ISoldier);
        */

        return theSoldier;
    }
}

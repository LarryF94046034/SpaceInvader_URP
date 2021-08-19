using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttrFactory : IAttrFactory
{
    private Dictionary<int,CharacterBaseAttr> m_SoldierAttrDB=null;
    private Dictionary<int,EnemyBaseAttr> m_EnemyAttrDB=null;
    private Dictionary<int,WeaponAttr> m_WeaponAttrDB=null;

    public AttrFactory()
    {
        InitSoldierAttr();
        InitEnemyAttr();
        InitWeaponAttr();
    }

    //建立所有SODIER數值
    private void  InitSoldierAttr()
    {
        m_SoldierAttrDB=new Dictionary<int, CharacterBaseAttr>();
        //生命力、移動速度、數值名稱
        m_SoldierAttrDB.Add(1,new CharacterBaseAttr(10,3.0f,"新兵"));
        m_SoldierAttrDB.Add(2,new CharacterBaseAttr(20,3.0f,"中士"));
        m_SoldierAttrDB.Add(3,new CharacterBaseAttr(30,3.0f,"上尉"));
        m_SoldierAttrDB.Add(11,new CharacterBaseAttr(3,3.0f,"勇士"));
    }
    //建立所有Enemy數值
    private void InitEnemyAttr()
    {
        m_EnemyAttrDB=new Dictionary<int, EnemyBaseAttr>();
        //生命力、移動速度、數值名稱、爆擊率
        m_EnemyAttrDB.Add(1,new EnemyBaseAttr(5,3.0f,"精靈",10));
        m_EnemyAttrDB.Add(2,new EnemyBaseAttr(15,3.1f,"山妖",20));
        m_EnemyAttrDB.Add(3,new EnemyBaseAttr(20,3.3f,"怪物",40));
        
    }
    //建立所有Weapon數值
    private void InitWeaponAttr()
    {
        m_WeaponAttrDB=new Dictionary<int, WeaponAttr>();
        //攻擊力、距離、數值名稱
        m_WeaponAttrDB.Add(1,new WeaponAttr(2,4,"短槍"));
        m_WeaponAttrDB.Add(2,new WeaponAttr(4,7,"長槍"));
        m_WeaponAttrDB.Add(3,new WeaponAttr(8,10,"火箭筒"));
    }



    public override SodierAttr GetSoldierAttr(int AttrID)
    {
        if(m_SoldierAttrDB.ContainsKey(AttrID)==false)
        {
            Debug.LogWarning("GetSoldierAttr:AttrID["+AttrID+"]數值不存在");
        }

        //產生數值物件並設定共享的數值資料
        SodierAttr NewAttr=new SodierAttr();
        NewAttr.SetSodierAttr(m_SoldierAttrDB[AttrID]);
        return NewAttr;
    }

    public override EnemyAttr GetEnemyAttr(int AttrID)
    {
        if(m_EnemyAttrDB.ContainsKey(AttrID)==false)
        {
            Debug.LogWarning("GetSoldierAttr:AttrID["+AttrID+"]數值不存在");
        }

        //產生數值物件並設定共享的數值資料
        EnemyAttr NewAttr=new EnemyAttr();
        NewAttr.SetEnemyAttr(m_EnemyAttrDB[AttrID]);
        return NewAttr;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//裝飾類型
public enum ENUM_AttrDecorator
{
    Prefix,
    Suffix,
    EnemyPrefix,
}
public class AttrFactory : IAttrFactory
{
    // private Dictionary<int,CharacterBaseAttr> m_SoldierAttrDB=null;
    // private Dictionary<int,EnemyBaseAttr> m_EnemyAttrDB=null;
    // private Dictionary<int,WeaponAttr> m_WeaponAttrDB=null;
    public Dictionary<int,CharacterBaseAttr> m_SoldierAttrDB=null;
    public Dictionary<int,EnemyBaseAttr> m_EnemyAttrDB=null;
    public Dictionary<int,WeaponAttr> m_WeaponAttrDB=null;
    [Header("加乘用數值")]
    public Dictionary<int,AdditionalAttr> m_AdditionalAttrDB=null;

    public AttrFactory()
    {
        InitSoldierAttr();
        InitEnemyAttr();
        InitWeaponAttr();

        InitAdditionalAttr();
    }

    [ContextMenu("InitAttrFactory")]
    public void InitAttrFactory()
    {
        InitSoldierAttr();
        InitEnemyAttr();
        InitWeaponAttr();

        InitAdditionalAttr();
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


        //新增的ENEMYATTR
        m_EnemyAttrDB.Add(11,new EnemyBaseThreeAttr(50,30.0f,"精靈王",30,30,10));
        
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


    //建立加乘用的數值
    private void  InitAdditionalAttr()
    {
        m_AdditionalAttrDB=new Dictionary<int, AdditionalAttr>();
        //字首產生時隨機產生
        m_AdditionalAttrDB.Add(11,new AdditionalAttr(3,0,"勇士"));
        m_AdditionalAttrDB.Add(12,new AdditionalAttr(5,0,"猛將"));
        m_AdditionalAttrDB.Add(13,new AdditionalAttr(10,0,"英雄"));

        //字尾存活下來即增加
        m_AdditionalAttrDB.Add(21,new AdditionalAttr(5,1,"1"));
        m_AdditionalAttrDB.Add(22,new AdditionalAttr(5,1,"2"));
        m_AdditionalAttrDB.Add(23,new AdditionalAttr(5,1,"3"));

        //爆擊增加
        m_AdditionalAttrDB.Add(31,new EnemyAdditionalAttr(0,0,"爆擊的",30));

        //精靈王增加
        m_AdditionalAttrDB.Add(41,new EnemyThreeAdditionalAttr(50,30,"精靈王增值",30,30,10));

    }



    public override SodierAttr GetSoldierAttr(int AttrID)
    {
        if(m_SoldierAttrDB.ContainsKey(AttrID)==false)
        {
            Debug.LogWarning("GetSoldierAttr:AttrID["+AttrID+"]數值不存在");
            return null;
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
            return null;
        }

        //產生數值物件並設定共享的數值資料
        EnemyAttr NewAttr=new EnemyAttr();
        //NewAttr.SetEnemyAttr(m_EnemyAttrDB[AttrID],m_EnemyAttrDB[AttrID].m_InitCritRate);
        NewAttr.SetEnemyAttr(m_EnemyAttrDB[AttrID]);
        return NewAttr;
    }

    public override AdditionalAttr GetAdditionalAttr(int AttrID)
    {
        if(m_AdditionalAttrDB.ContainsKey(AttrID)==false)
        {
            Debug.LogWarning("GetSoldierAttr:AttrID["+AttrID+"]數值不存在");
            return null;
        }

        //直接回傳加乘用的數值
        return m_AdditionalAttrDB[AttrID];
    }
    public override AdditionalAttr GetEnemyAdditionalAttr(int AttrID)
    {
        if(m_AdditionalAttrDB.ContainsKey(AttrID)==false)
        {
            Debug.LogWarning("GetSoldierAttr:AttrID["+AttrID+"]數值不存在");
            return null;
        }

        //直接回傳加乘用的數值
        return m_AdditionalAttrDB[AttrID];
    }
    public override SodierAttr GetEliteSoldierAttr(ENUM_AttrDecorator emType, int AttrID, SodierAttr theSodierAttr)
    {
        //1.取得加乘效果的數值
        AdditionalAttr theAdditionalAttr=GetAdditionalAttr(AttrID);

        if(theAdditionalAttr==null)
        {
            Debug.LogWarning("GetEliteSoldierAttr:加乘數值["+AttrID+"]不存在");
            return theSodierAttr;
        }
        //2.產生裝飾者
        BaseAttrDecorator theAttrDecorator=null;
        switch(emType)
        {
            case ENUM_AttrDecorator.Prefix:
                theAttrDecorator=new PrefixBaseAttr();
                break;
            case ENUM_AttrDecorator.Suffix:
                theAttrDecorator=new SuffixBaseAttr();
                break;

        }
        if(theAttrDecorator==null)
        {
            Debug.LogWarning("GetEliteSoldierAttr:無法針對["+AttrID+"]產生裝飾者");
            return theSodierAttr;
        }
        //3.設定裝飾對象及加乘數值
        theAttrDecorator.SetComponent(theSodierAttr.GetBaseAttr());
        theAttrDecorator.SetAdditionalAttr(theAdditionalAttr);

        //4.設定新的數值後回傳
        theSodierAttr.SetBaseAttr(theAttrDecorator);

        //5.回傳
        return theSodierAttr;

    }

    public override EnemyAttr GetEliteEnemyAttr(ENUM_AttrDecorator emType, int AttrID, EnemyAttr theSodierAttr)
    {
        //1.取得加乘效果的數值
        AdditionalAttr theAdditionalAttr=GetEnemyAdditionalAttr(AttrID);

        if(theAdditionalAttr==null)
        {
            Debug.LogWarning("GetEliteSoldierAttr:加乘數值["+AttrID+"]不存在");
            return theSodierAttr;
        }
        //2.產生裝飾者
        EnemyAttrDecorator theAttrDecorator=null;
        switch(emType)
        {
            case ENUM_AttrDecorator.EnemyPrefix:
                theAttrDecorator=new PrefixEnemyAttr();
                break;
            
        }
        if(theAttrDecorator==null)
        {
            Debug.LogWarning("GetEliteSoldierAttr:無法針對["+AttrID+"]產生裝飾者");
            return theSodierAttr;
        }
        //3.設定裝飾對象及加乘數值
        theAttrDecorator.SetComponent(theSodierAttr);
        theAttrDecorator.SetAdditionalAttr((EnemyAdditionalAttr)theAdditionalAttr);

        Debug.Log(theAttrDecorator.GetCritRate());

        //4.設定新的數值後回傳
        theSodierAttr.SetEnemyAttr(new CharacterBaseAttr(theAttrDecorator.GetMaxHP(),theAttrDecorator.GetMoveSpeed(),theAttrDecorator.GetAttrName()),theAttrDecorator.GetCritRate());
        //theSodierAttr.SetEnemyAttr(theAttrDecorator);

        //5.回傳
        return theSodierAttr;

    }

    public override EnemyAttr GetKingEnemyAttr(ENUM_AttrDecorator emType, int AttrID, EnemyAttr theSodierAttr)
    {
        //1.取得加乘效果的數值
        AdditionalAttr theAdditionalAttr=GetEnemyAdditionalAttr(AttrID);

        if(theAdditionalAttr==null)
        {
            Debug.LogWarning("GetEliteSoldierAttr:加乘數值["+AttrID+"]不存在");
            return theSodierAttr;
        }
        //2.產生裝飾者
        EnemyAttrDecorator theAttrDecorator=null;
        switch(emType)
        {
            case ENUM_AttrDecorator.EnemyPrefix:
                theAttrDecorator=new PrefixEnemyAttr();
                break;
            
        }
        if(theAttrDecorator==null)
        {
            Debug.LogWarning("GetEliteSoldierAttr:無法針對["+AttrID+"]產生裝飾者");
            return theSodierAttr;
        }
        //3.設定裝飾對象及加乘數值
        theAttrDecorator.SetComponent(theSodierAttr);
        theAttrDecorator.SetAdditionalAttr((EnemyAdditionalAttr)theAdditionalAttr);

        Debug.Log(theAttrDecorator.GetCritRate());

        //4.設定新的數值後回傳
        theSodierAttr.SetEnemyAttr(new CharacterBaseAttr(theAttrDecorator.GetMaxHP(),theAttrDecorator.GetMoveSpeed(),theAttrDecorator.GetAttrName()),theAttrDecorator.GetCritRate());
        //theSodierAttr.SetEnemyAttr(theAttrDecorator);

        //5.回傳
        return theSodierAttr;

    }
    
}

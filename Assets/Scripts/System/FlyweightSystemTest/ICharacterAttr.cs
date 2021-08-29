using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ICharacterAttr 
{
    protected BaseAttr m_BaseAttr=null;    //基本腳色數值
    protected int m_NowHP;   //目前HP
    //protected IAttrStra
    public ICharacterAttr(){}
    //設定基本屬性
    public void SetBaseAttr(BaseAttr baseAttr)
    {
        m_BaseAttr=baseAttr;
    }
    //取得基本屬性
    public BaseAttr GetBaseAttr()
    {
        return m_BaseAttr;
    }


    // //設定計算策略
    // protected void SetAttStrategy(BaseAttr baseAttr)
    // {
    //     m_AttrStrategy=
    // }
    // //取得計算策略
    // protected BaseAttr GetAttStrategy()
    // {
    //     return m_AttrStrategy;
    // }

    //目前HP
    public int GetNowHP()
    {
        return m_NowHP;
    }
    //最大HP
    public virtual int GetMaxHP()
    {
        return m_BaseAttr.GetMaxHP();      //取
    }
    //移動速度
    public virtual float GetMoveSpeed()
    {
        return m_BaseAttr.GetMoveSpeed();   //取
    }
    //取得數值名稱
    public virtual string GetAttrName()
    {
        return m_BaseAttr.GetAttrName();   //取
    }
    //初始腳色數值
    public virtual void InitAttr()
    {
        //m_AttrStrategy.InitAttr(this);
        //FullNowHP();
    }
}

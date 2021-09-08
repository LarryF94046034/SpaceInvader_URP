using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttr : ICharacterAttr
{
    protected int m_CritRate=0;  //爆擊率
    protected int m_MissRate=0;  //閃避率
    protected int m_RecoverIncreaseRate=0;  //回復增加率
    public EnemyAttr(){}


    //設定角色數值
    public void SetEnemyAttr(EnemyBaseAttr EnemyBaseAttr)
    {
        //共享元件
        base.SetBaseAttr(EnemyBaseAttr);
        //外部參數
        m_CritRate = EnemyBaseAttr.GetInitCritRate();
    }
    
    //設定角色數值
    public void SetEnemyAttr(BaseAttr EnemyBaseAttr,int CritRate)
    {
        //共享元件
        base.SetBaseAttr(EnemyBaseAttr);
        //外部參數
        m_CritRate=CritRate;
    }

    //protected int m_CritRate=0;  //爆擊率   Get Cut

    public virtual int GetCritRate()
    {
        return m_CritRate;
    }
    public virtual int GetMissRate()
    {
        return m_CritRate;
    }
    public virtual int GetRecoverIncreaseRate()
    {
        return m_CritRate;
    }
}

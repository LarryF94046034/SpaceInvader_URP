using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttr : ICharacterAttr
{
    protected int m_CritRate=0;  //爆擊率
    public EnemyAttr(){}


    //設定角色數值
    public void SetEnemyAttr(EnemyBaseAttr EnemyBaseAttr)
    {
        //共享元件
        base.SetBaseAttr(EnemyBaseAttr);
        //外部參數
        m_CritRate=EnemyBaseAttr.InitCritRate;
    }

    //protected int m_CritRate=0;  //爆擊率   Get Cut
}

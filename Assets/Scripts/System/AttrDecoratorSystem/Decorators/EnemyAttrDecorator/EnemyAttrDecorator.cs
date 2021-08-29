using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttrDecorator : EnemyAttr
{
    protected EnemyAttr m_Component;   //被裝飾對象
    protected EnemyAdditionalAttr m_AdditionalAttr;  //代表額外加乘的數值
    //protected AdditionalAttr m_AdditionalAttr;  //代表額外加乘的數值

    //設定裝飾的目標
    public void SetComponent(EnemyAttr theComponent)
    {
        m_Component=theComponent;
    }
    //設定額外使用的值
    public void SetAdditionalAttr(EnemyAdditionalAttr theAdditionalAttr)
    {
        m_AdditionalAttr=theAdditionalAttr;
    }
    public override int GetMaxHP()
    {
        return m_Component.GetMaxHP();
    }
    public override float GetMoveSpeed()
    {
        return m_Component.GetMoveSpeed();
    }
    public override string GetAttrName()
    {
        return m_Component.GetAttrName();
    }

    public override int GetCritRate()
    {
        return m_Component.GetCritRate();
    }
}

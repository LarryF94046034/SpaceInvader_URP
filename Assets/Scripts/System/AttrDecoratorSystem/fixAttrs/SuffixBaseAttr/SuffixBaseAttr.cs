using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuffixBaseAttr : BaseAttrDecorator
{
    public SuffixBaseAttr(){}

    public override int GetMaxHP()
    {
        return m_Component.GetMaxHP()+m_AdditionalAttr.GetStrength();
    }
    public override float GetMoveSpeed()
    {
        return m_Component.GetMoveSpeed()+m_AdditionalAttr.GetAgility()*0.2f;
    }
    public override string GetAttrName()
    {
        return m_Component.GetAttrName()+m_AdditionalAttr.GetName();
    }
}

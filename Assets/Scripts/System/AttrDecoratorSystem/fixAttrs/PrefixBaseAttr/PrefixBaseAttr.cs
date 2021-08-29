using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefixBaseAttr : BaseAttrDecorator
{
    public PrefixBaseAttr(){}

    public override int GetMaxHP()
    {
        return m_AdditionalAttr.GetStrength()+m_Component.GetMaxHP();
    }
    public override float GetMoveSpeed()
    {
        return m_AdditionalAttr.GetAgility()*0.2f+m_Component.GetMoveSpeed();
    }
    public override string GetAttrName()
    {
        return m_AdditionalAttr.GetName()+m_Component.GetAttrName();
    }
}

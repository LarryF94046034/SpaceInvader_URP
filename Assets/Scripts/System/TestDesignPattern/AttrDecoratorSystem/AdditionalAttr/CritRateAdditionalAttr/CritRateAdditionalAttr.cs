using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CritRateAdditionalAttr : AdditionalAttr
{
    private int m_CritRate;
    public CritRateAdditionalAttr(int Strength,int Agility,string Name,int CritRate):base(Strength,Agility,Name)
    {
        m_CritRate=CritRate;
    }



    
}

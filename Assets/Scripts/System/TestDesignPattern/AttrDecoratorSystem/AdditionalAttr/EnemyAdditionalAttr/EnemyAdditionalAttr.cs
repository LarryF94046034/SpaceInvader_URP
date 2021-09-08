using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAdditionalAttr : AdditionalAttr
{
    private int m_CritRate;
    public EnemyAdditionalAttr(int Strength,int Agility,string Name,int CritRate):base(Strength,Agility,Name)
    {
        m_CritRate=CritRate;
    }

    public override int GetStrength()
    {
        return m_Strength;
    }
    public override int GetAgility()
    {
        return m_Agility;
    }
    public override string GetName()
    {
        return m_Name;
    }


    public int GetCritRate()
    {
        return m_CritRate;
    }


}

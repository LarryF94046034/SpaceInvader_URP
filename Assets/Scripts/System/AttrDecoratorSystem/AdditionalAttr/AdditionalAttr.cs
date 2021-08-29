using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdditionalAttr 
{
    protected int m_Strength;  //力量
    protected int m_Agility;  //敏捷
    protected string m_Name;  //數值的名稱
    public AdditionalAttr(int Strength,int Agility,string Name)
    {
        m_Strength=Strength;
        m_Agility=Agility;
        m_Name=Name;
    }
    public virtual int GetStrength()
    {
        return m_Strength;
    }
    public virtual int GetAgility()
    {
        return m_Agility;
    }
    public virtual string GetName()
    {
        return m_Name;
    }
}

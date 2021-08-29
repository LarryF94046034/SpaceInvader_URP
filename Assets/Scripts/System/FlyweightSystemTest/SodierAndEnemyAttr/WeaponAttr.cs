using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponAttr 
{
    private int m_MaxHP;  //最高HP
    private float m_MoveSpeed;  //目前移速
    private string m_AttrName;  //數值名稱
    private float m_CritRate;  //爆擊率

    public WeaponAttr(int MaxHP,float MoveSpeed,string AttrName)
    {
        this.m_MaxHP=MaxHP;
        this.m_MoveSpeed=MoveSpeed;
        this.m_AttrName=AttrName;
    }
}

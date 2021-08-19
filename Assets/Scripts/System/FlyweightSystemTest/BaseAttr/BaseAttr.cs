// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class BaseAttr 
// {
//     private int m_MaxHP;  //最高HP
//     private float m_MoveSpeed;  //目前移速
//     private string m_AttrName;  //數值名稱
//     public BaseAttr(int MaxHP,float MoveSpeed,string AttrName)
//     {
//         this.m_MaxHP=MaxHP;
//         this.m_MoveSpeed=MoveSpeed;
//         this.m_AttrName=AttrName;
//     }
//     public int GetMaxHP()
//     {
//         return m_MaxHP;
//     }
//     public float GetMoveSpeed()
//     {
//         return m_MoveSpeed;
//     }
//     public string GetAttrName()
//     {
//         return m_AttrName;
//     }
// }


// 可以被共用的基本角色數值界面
public abstract class BaseAttr
{			
	public abstract int 	GetMaxHP();
	public abstract float 	GetMoveSpeed();
	public abstract string 	GetAttrName();
}
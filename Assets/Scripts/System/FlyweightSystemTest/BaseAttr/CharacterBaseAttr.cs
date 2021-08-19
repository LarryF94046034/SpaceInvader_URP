using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 實作可以被共用的基本角色數值
public class CharacterBaseAttr : BaseAttr
{
	private int 	m_MaxHP;		// 最高HP值
	private float  	m_MoveSpeed;	// 目前移動速度
	private string 	m_AttrName;		// 數值的名稱	

	public CharacterBaseAttr(int MaxHP,float MoveSpeed, string AttrName)
	{
		m_MaxHP = MaxHP;
		m_MoveSpeed = MoveSpeed;
		m_AttrName = AttrName;
	}

	public override int GetMaxHP()
	{
		return m_MaxHP;
	}

	public override float GetMoveSpeed()
	{
		return m_MoveSpeed;
	}

	public override string GetAttrName()
	{
		return m_AttrName;
	}
}

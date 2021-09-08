using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ICharacter 
{
    protected ICharacterAttr m_Attribute = null;// 數值
    // 取得目前的值
	public ICharacterAttr GetCharacterAttr()
	{
		return m_Attribute;
	}

    #region 角色數值
	// 設定角色數值
	public virtual void SetCharacterAttr( ICharacterAttr CharacterAttr)
	{
		// 設定
		m_Attribute = CharacterAttr;
		m_Attribute.InitAttr ();

		// // 設定移動速度
		// m_NavAgent.speed = m_Attribute.GetMoveSpeed();
		// //Debug.Log ("設定移動速度:"+m_NavAgent.speed);

		// // 名稱
		// m_Name = m_Attribute.GetAttrName();
	}
	#endregion
}

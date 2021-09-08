using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SodierAttrSO", menuName = "ScriptableObjects/Character/Attr/Sodier")]
public class SodierAttrSO : ScriptableObject
{
    [Header("SodierAttr")]
    public int m_SoldierLv;  //Soldier等級
    public int m_AddMaxHP;  //因等級新增的HP
    [Header("BaseAttr")]
    public int 	m_MaxHP;		// 最高HP值
	public float  	m_MoveSpeed;	// 目前移動速度
	public string 	m_AttrName;		// 數值的名稱	

}

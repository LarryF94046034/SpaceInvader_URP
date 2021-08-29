using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyAttrSO", menuName = "ScriptableObjects/Character/Attr/Enemy")]
public class EnemyAttrSO : ScriptableObject
{
    [Header("EnemyAttr")]
    public int m_CritRate;  //爆擊率
    public int m_MissRate;  //閃避率
    public int m_RecoverIncreaseRate;  //回復增加率
    [Header("BaseAttr")]
    public int 	m_MaxHP;		// 最高HP值
	public float  	m_MoveSpeed;	// 目前移動速度
	public string 	m_AttrName;		// 數值的名稱

    
}

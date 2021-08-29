using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBaseThreeAttr : EnemyBaseAttr
{
    protected int m_InitMissRate=0;  //閃避率
    protected int m_InitRecoverIncreaseRate=0;  //回復增加率

    public EnemyBaseThreeAttr(int MaxHP,float MoveSpeed, string AttrName, int CritRate,int InitMissRate,int InitRecoverIncreaseRate):base(MaxHP,MoveSpeed,AttrName,CritRate)
	{
		m_InitCritRate =CritRate;
	}

    public int GetInitMissRate()
    {
        return m_InitMissRate;
    }
    public int GetInitRecoverIncreaseRate()
    {
        return m_InitRecoverIncreaseRate;
    }
}

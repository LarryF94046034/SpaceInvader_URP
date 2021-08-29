using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyThreeAdditionalAttr : EnemyAdditionalAttr
{
    protected int m_MissRate=0;  //閃避率
    protected int m_RecoverIncreaseRate=0;  //回復增加率
    public EnemyThreeAdditionalAttr(int Strength,int Agility,string Name,int CritRate,int MissRate,int RecoverIncreaseRate):base(Strength,Agility,Name,CritRate)
    {
        m_MissRate=MissRate;
        m_RecoverIncreaseRate=RecoverIncreaseRate;
    }
}

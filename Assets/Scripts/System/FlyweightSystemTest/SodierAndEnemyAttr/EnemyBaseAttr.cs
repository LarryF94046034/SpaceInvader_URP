using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBaseAttr : CharacterBaseAttr
{
    public int 	m_InitCritRate;	// 爆擊率

    public EnemyBaseAttr(int MaxHP,float MoveSpeed, string AttrName, int CritRate):base(MaxHP,MoveSpeed,AttrName)
	{
		m_InitCritRate =CritRate;
	}

    public int InitCritRate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

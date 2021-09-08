using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Soldier類型
public enum ENUM_Soldier
{
	Null = 0,
	Rookie	= 1,	// 新兵
	Sergeant= 2,	// 中士
	Captain = 3,	// 上尉
	Captive	= 4, 	// 俘兵
	Max,
}

public abstract class ISoldier : ICharacter
{
    protected ENUM_Soldier m_emSoldier = ENUM_Soldier.Null;
    // 播放音效
	public abstract void DoPlayKilledSound();

	// 播放特效
	public abstract void DoShowKilledEffect();
}

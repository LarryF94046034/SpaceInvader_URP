using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IEnemy : ICharacter
{
    // 播放音效
	public abstract void DoPlayHitSound();
	
	// 播放特效
	public abstract void DoShowHitEffect();
}

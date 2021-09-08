using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierCaptive : ISoldier
{
    private IEnemy m_Captive=null;

    public SoldierCaptive(IEnemy theEnemy)
    {
        m_emSoldier=ENUM_Soldier.Captive;  //ISOLDIER
        m_Captive=theEnemy; //SOLDIERCAPTIVE

        //設定成像
        //SetGameObject

        //將ENEMY數值變成SOLDIER用的
        SodierAttr tempAttr=new SodierAttr();
        tempAttr.SetSodierAttr(theEnemy.GetCharacterAttr().GetBaseAttr());
        tempAttr.SetAttStrategy(theEnemy.GetCharacterAttr().GetAttStrategy());
        tempAttr.SetSoldierLv(1);  //設定為1級
        SetCharacterAttr(tempAttr);

        //設定武器

        //更改為SoldierAI
    }

    //播放音效
    public override void DoPlayKilledSound()
    {
        m_Captive.DoPlayHitSound();
    }
    //播放特效
    public override void DoShowKilledEffect()
    {
        m_Captive.DoPlayHitSound();
    }
    // //執行Visitor
    // public override void RunVisitor()
    // {
    //     RunVisitor.VisitSoldierCaptive(this);
    // }
}

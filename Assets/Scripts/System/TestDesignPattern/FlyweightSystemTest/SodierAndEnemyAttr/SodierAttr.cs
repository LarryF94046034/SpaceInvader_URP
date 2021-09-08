using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SodierAttr : ICharacterAttr
{
    protected int m_SoldierLv;  //Soldier等級
    protected int m_AddMaxHP;  //因等級新增的HP
    public SodierAttr(){}

    //設定角色數值
    public void SetSodierAttr(BaseAttr baseAttr)
    {
        base.SetBaseAttr(baseAttr);
        //外部參數
        m_SoldierLv=1;
        m_AddMaxHP=0;
    }

    //protected int m_SoldierLv;  //Soldier等級   SET GET

    //protected int m_AddMaxHP;  //因等級新增的HP   GET

    public void AddMaxHP(int AddMaxHP)   //SetAdd
    {
        m_AddMaxHP=AddMaxHP;
    }
    #region SETGET SoldierLv
    // 設定等級
	public void SetSoldierLv(int Lv)
	{
		m_SoldierLv = Lv;
	}

	// 取得等級
	public int GetSoldierLv()
	{
		return m_SoldierLv ;
	}
    #endregion
    
    
}

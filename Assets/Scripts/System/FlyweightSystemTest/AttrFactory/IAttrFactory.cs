using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Sirenix.OdinInspector;

public class IAttrFactory : MonoBehaviour
{
    public virtual SodierAttr GetSoldierAttr(int AttrID)
    {
        return null;
    }

    public virtual EnemyAttr GetEnemyAttr(int AttrID)
    {
        return null;
    }
    public virtual AdditionalAttr GetAdditionalAttr(int AttrID)
    {
        return null;
    }
    public virtual AdditionalAttr GetEnemyAdditionalAttr(int AttrID)
    {
        return null;
    }

    //取得Sodier數值:有字首字尾加乘
    public virtual SodierAttr GetEliteSoldierAttr(ENUM_AttrDecorator emType,int AttrID,SodierAttr theSodierAttr)
    {
        return null;
    }
    //取得Enemy數值:有字首字尾加乘
    public virtual EnemyAttr GetEliteEnemyAttr(ENUM_AttrDecorator emType,int AttrID,EnemyAttr theSodierAttr)
    {
        return null;
    }

    //取得Enemy King數值:有字首字尾加乘
    public virtual EnemyAttr GetKingEnemyAttr(ENUM_AttrDecorator emType,int AttrID,EnemyAttr theSodierAttr)
    {
        return null;
    }


}

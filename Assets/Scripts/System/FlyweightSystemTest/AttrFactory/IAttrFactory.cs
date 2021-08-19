using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEnemyAttr : MonoBehaviour
{
    public AttrFactory attrFactory;
    public EnemyAttrSO sodierAttrSO;
    // Start is called before the first frame update
    void Start()
    {
        EnemyAttr sodierAttr=attrFactory.GetEnemyAttr(1);

        Debug.Log(sodierAttr.GetMaxHP());
        Debug.Log(sodierAttr.GetMoveSpeed());
        Debug.Log(sodierAttr.GetAttrName());
        Debug.Log(sodierAttr.GetCritRate());
        Debug.Log(sodierAttrSO);
        sodierAttrSO.m_MaxHP=sodierAttr.GetMaxHP();
        sodierAttrSO.m_MoveSpeed=sodierAttr.GetMoveSpeed();
        sodierAttrSO.m_AttrName=sodierAttr.GetAttrName();

        EnemyAttr tmpAttr=attrFactory.GetEliteEnemyAttr(ENUM_AttrDecorator.EnemyPrefix,31,sodierAttr);

        sodierAttrSO.m_MaxHP=tmpAttr.GetMaxHP();
        sodierAttrSO.m_MoveSpeed=tmpAttr.GetMoveSpeed();
        sodierAttrSO.m_AttrName=tmpAttr.GetAttrName();

        sodierAttrSO.m_CritRate=tmpAttr.GetCritRate();


        //測試精靈王

        // EnemyAttr sodierAttr=attrFactory.GetEnemyAttr(11);

        // Debug.Log(sodierAttr.GetMaxHP());
        // Debug.Log(sodierAttr.GetMoveSpeed());
        // Debug.Log(sodierAttr.GetAttrName());
        // Debug.Log(sodierAttr.GetCritRate());
        // Debug.Log(sodierAttrSO);
        // sodierAttrSO.m_MaxHP=sodierAttr.GetMaxHP();
        // sodierAttrSO.m_MoveSpeed=sodierAttr.GetMoveSpeed();
        // sodierAttrSO.m_AttrName=sodierAttr.GetAttrName();

        // EnemyAttr tmpAttr=attrFactory.GetEliteEnemyAttr(ENUM_AttrDecorator.EnemyPrefix,41,sodierAttr);

        // sodierAttrSO.m_MaxHP=tmpAttr.GetMaxHP();
        // sodierAttrSO.m_MoveSpeed=tmpAttr.GetMoveSpeed();
        // sodierAttrSO.m_AttrName=tmpAttr.GetAttrName();

        // sodierAttrSO.m_CritRate=tmpAttr.GetCritRate();
        // sodierAttrSO.m_MissRate=tmpAttr.GetMissRate();
        // sodierAttrSO.m_RecoverIncreaseRate=tmpAttr.GetRecoverIncreaseRate();
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

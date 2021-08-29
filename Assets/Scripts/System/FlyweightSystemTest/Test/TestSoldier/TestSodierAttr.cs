using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSodierAttr : MonoBehaviour
{
    public AttrFactory attrFactory;
    public SodierAttrSO sodierAttrSO;

    
    // Start is called before the first frame update
    void Start()
    {
        SodierAttr sodierAttr=attrFactory.GetSoldierAttr(1);

        Debug.Log(sodierAttr.GetMaxHP());
        Debug.Log(sodierAttr.GetMoveSpeed());
        Debug.Log(sodierAttr.GetAttrName());
        Debug.Log(sodierAttrSO);
        sodierAttrSO.m_MaxHP=sodierAttr.GetMaxHP();
        sodierAttrSO.m_MoveSpeed=sodierAttr.GetMoveSpeed();
        sodierAttrSO.m_AttrName=sodierAttr.GetAttrName();

        SodierAttr tmpAttr=attrFactory.GetEliteSoldierAttr(ENUM_AttrDecorator.Prefix,12,sodierAttr);

        sodierAttrSO.m_MaxHP=tmpAttr.GetMaxHP();
        sodierAttrSO.m_MoveSpeed=tmpAttr.GetMoveSpeed();
        sodierAttrSO.m_AttrName=tmpAttr.GetAttrName();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

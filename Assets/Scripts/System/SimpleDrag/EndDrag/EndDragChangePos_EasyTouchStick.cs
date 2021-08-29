using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndDragChangePos_EasyTouchStick : MonoBehaviour
{
    public GameObject controlObject;
    public GameObject dragObject;
    public GameObject easyTouchStick;
    
    Vector3 distance;
    void Start()
    {
        distance=dragObject.transform.localPosition-controlObject.transform.localPosition;
    }
    public void DragMethod()
    {
        dragObject.transform.position=Input.mousePosition;
    }
    public void EndDragMethod()
    {   
        controlObject.transform.localPosition=dragObject.transform.localPosition+distance;
        GameSystems.Instance.playerSkillCtl.easyTouchDemoLogic.orginPos=easyTouchStick.transform.position;
    }
}

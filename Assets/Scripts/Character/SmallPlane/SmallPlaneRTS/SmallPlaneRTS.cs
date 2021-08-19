using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallPlaneRTS : MonoBehaviour
{
    [Header("第一段")]
    public List<GameObject> planes=new List<GameObject>();
    public GameObject targetPositionObj;
    public float[] ringDistance=new float[3];
    public int[] ringPositionCount=new int[3];
    public float moveTime;
    public float angleOffset;
    [Header("第二段")]
    public GameObject targetPositionObj1;
    public float moveToPlayerTime=2.0f;
    public Vector3 frontVector=new Vector3(0,2.0f,0);
    // Start is called before the first frame update
    void Start()
    {
        RTSManager.Instance.RTSControl(planes,targetPositionObj,ringDistance,ringPositionCount,moveTime,angleOffset);
        FunctionTimer.Create(()=>{
            RTSManager.Instance.RTSControl(planes,targetPositionObj,ringDistance,ringPositionCount,moveTime,angleOffset+50);
        },3.0f);
        FunctionTimer.Create(()=>{
            RTSManager.Instance.RTSControl(planes,targetPositionObj,ringDistance,ringPositionCount,moveTime,angleOffset+100);
        },7.0f);
        FunctionTimer.Create(()=>{
            RTSManager.Instance.RTSControl(planes,targetPositionObj,ringDistance,ringPositionCount,moveTime,angleOffset+110);
        },8.0f);
        FunctionTimer.Create(()=>{
            RTSManager.Instance.RTSControl(planes,targetPositionObj,ringDistance,ringPositionCount,moveTime,angleOffset+120);
        },9.0f);
        FunctionTimer.Create(()=>{
            RTSManager.Instance.ToPlayerFront(planes,GameSystems.Instance.playerSkillCtl.player,moveToPlayerTime,frontVector);
        },11.0f);
        FunctionTimer.Create(()=>{
            RTSManager.Instance.RTSControl(planes,targetPositionObj,ringDistance,ringPositionCount,moveTime,angleOffset+120);
        },13.0f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

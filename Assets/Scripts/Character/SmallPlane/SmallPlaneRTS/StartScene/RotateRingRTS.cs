using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateRingRTS : MonoBehaviour
{
    [Header("RTS")]
    public List<GameObject> planes=new List<GameObject>();
    public GameObject targetPositionObj;
    public float[] ringDistance=new float[3];
    public int[] ringPositionCount=new int[3];
    public float moveTime;
    public float angleOffset;
    [Header("TIME")]
    public float timer;
    public float divideTime;
    [Header("Rotate")]
    public float rotateTime;
    public float rotateAdd;    //添加的值
    public float rotateAddRate;  //添加的值隨時間 添加變化
    public List<Vector3> rotateVector=new List<Vector3>();
    // Start is called before the first frame update
    void Start()
    {
        RTSManager.Instance.RTSControl_NoStartPoint(planes,targetPositionObj,ringDistance,ringPositionCount,moveTime,angleOffset);
        RTSManager.Instance.RTSRingRotateControl(planes,rotateTime,rotateAdd,rotateVector);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timer+=Time.fixedDeltaTime;
        if(timer>=divideTime)
        {
            angleOffset+=10;
            if(angleOffset>=360)
            {
                angleOffset=0;
            }

            RTSManager.Instance.RTSControl_NoStartPoint(planes,targetPositionObj,ringDistance,ringPositionCount,moveTime,angleOffset);
            //RTSManager.Instance.RTSRingRotateControl(planes,rotateTime,rotateAdd,rotateVector);
            rotateAdd+=rotateAddRate;

            timer=0;
        }
    }
}

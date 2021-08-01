using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallPlaneRTS : MonoBehaviour
{
    public List<GameObject> planes=new List<GameObject>();
    public GameObject targetPositionObj;
    public float[] ringDistance=new float[3];
    public int[] ringPositionCount=new int[3];
    public float moveTime;
    // Start is called before the first frame update
    void Start()
    {
        RTSManager.Instance.RTSControl(planes,targetPositionObj,ringDistance,ringPositionCount,moveTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

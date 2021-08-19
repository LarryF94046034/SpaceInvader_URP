using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateManager : MonoBehaviour
{
    public List<Transform> rotateTrans=new List<Transform>();
    public Vector3 rotateEuler;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        for(int i=0;i<rotateTrans.Count;i++)
        {
            rotateTrans[i].transform.Rotate(rotateEuler,Space.Self);
        }
    }
}

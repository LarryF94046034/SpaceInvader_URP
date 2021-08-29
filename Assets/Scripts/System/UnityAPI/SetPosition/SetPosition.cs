using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPosition : MonoBehaviour
{
    public float time;
    public Vector3 positionVector;
    // Start is called before the first frame update
    void Start()
    {
        FunctionTimer.Create(()=>{
            this.transform.position=positionVector;
        },time);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

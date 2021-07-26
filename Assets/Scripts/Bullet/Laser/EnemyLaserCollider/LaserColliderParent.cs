using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserColliderParent : MonoBehaviour
{
    private List<GameObject> timerList=new List<GameObject>();
    private Vector3 moveVector=new Vector3();
    void Start()
    {
        FunctionTimer.Create(()=>{
            this.gameObject.SetActive(false);
        },3.0f,null,timerList);
        

        // FunctionTimer.Create(()=>{
        //     this.gameObject.transform.parent.gameObject.SetActive(false);
        // },3.0f,null,timerList);
    }

    void OnEnable()
    {
        FunctionTimer.Create(()=>{
            this.gameObject.SetActive(false);
        },3.0f,null,timerList);
        

        // FunctionTimer.Create(()=>{
        //     this.gameObject.transform.parent.gameObject.SetActive(false);
        // },3.0f,null,timerList);
    }
    void OnDisable()
    {
        for(int i=0;i<timerList.Count;i++)
        {
            Destroy(timerList[i]);
        }
        // cancelInvoke=true;
        // CancelInvoke();

    }


    void Update()
    {
        //gameObject.transform.position += new Vector3(0,0.1f,0);
        gameObject.transform.position += moveVector*0.1f;
        
        
    }

    public void SetRotation()
    {
        moveVector.x=transform.forward.x;
        moveVector.y=transform.forward.y;
    }

    public void BulletSetRotationFromPlane(GameObject tmpGObj)
    {
        this.transform.rotation=tmpGObj.transform.rotation;
    }
}

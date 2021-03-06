using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLaserParent : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    private List<GameObject> timerList=new List<GameObject>();
    public Vector3 moveVector=new Vector3(0,1,0);
    void Start()
    {
        //rigidbody2D.velocity=moveVector;


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

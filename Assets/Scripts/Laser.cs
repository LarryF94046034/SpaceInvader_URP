using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    private bool cancelInvoke=false;
    private Vector3 moveVector=new Vector3();
    private List<GameObject> timerList=new List<GameObject>();
    // Start is called before the first frame update
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
    void SetFalse()
    {
        if(cancelInvoke==true)
        {
            return;
        }
        if(this.transform.parent.name=="Pool")
        {
            this.gameObject.SetActive(false);
        }
        else
        {
            Destroy(this.gameObject);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        moveVector.x=transform.forward.x;
        moveVector.y=transform.forward.y;
        //gameObject.transform.position += new Vector3(0,0.1f,0);
        gameObject.transform.position += moveVector*0.1f;
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Enemy")
        {
            //Destroy(col.gameObject);
            Debug.Log("HitEnemy");
            Destroy(col.gameObject);
        }

        if ((col.tag == "TopSide")&&(col.tag=="RightSide")&&(col.tag=="LeftSide")&&(col.tag=="BottomSide"))
        {
            //Destroy(this.gameObject);
            this.gameObject.SetActive(false);
        }
    }

    public void BulletSetRotationFromPlane(GameObject tmpGObj)
    {
        this.transform.rotation=tmpGObj.transform.rotation;
    }
    public void SetLocalRotation(GameObject FromGObj,GameObject SetGObj)
    {
        SetGObj.transform.localRotation=FromGObj.transform.localRotation;
    }
    public void SetLocalPosition(GameObject FromGObj,GameObject SetGObj)
    {
        SetGObj.transform.localPosition=FromGObj.transform.localPosition;
    }
}

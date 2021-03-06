using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserChild : MonoBehaviour
{
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
}

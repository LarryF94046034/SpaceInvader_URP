using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossLeftCircleShoot : MonoBehaviour
{
    public BossLeftStateCtl bossLeftStateCtl;
    

    // Update is called once per frame
    void Update()
    {
        
    }

    void Start()
    {
        if(this.gameObject.activeSelf==true)
        {
            GameSystems.Instance.bossLeftShootLogic.CircleShoot();
        }
        
        //Debug.Log("LeftShoot");
        //Debug.Log(BossLeftStateCtl.Instance.timer);
        this.gameObject.SetActive(false);
        Destroy(this);
        FunctionTimer.Create(()=>
        {
            BossLeftStateCtl.Instance.circleShoot.AddComponent<BossLeftCircleShoot>();
        },1.0f);
    }


    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossLeftCircleRotateShoot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(this.gameObject.activeSelf==true)
        {
            GameSystems.Instance.bossLeftShootLogic.CircleRotateShoot();
        }
        //Debug.Log("LeftShoot");
        //Debug.Log(BossLeftStateCtl.Instance.timer);
        this.gameObject.SetActive(false);
        Destroy(this);
        FunctionTimer.Create(()=>
        {
            BossLeftStateCtl.Instance.circleRotateShoot.AddComponent<BossLeftCircleRotateShoot>();
        },1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

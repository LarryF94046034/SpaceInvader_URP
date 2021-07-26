using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserColliderChild : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            PlayerSkillCtl.Instance.playerBloodLogic.ReduceBlood(50);
            this.gameObject.transform.parent.gameObject.SetActive(false);
        }

        // if (col.tag == "Enemy")
        // {
        //     //Destroy(col.gameObject);
        //     Debug.Log("HitEnemy");
        //     Destroy(col.gameObject);
        // }

        if ((col.tag == "TopSide")&&(col.tag=="RightSide")&&(col.tag=="LeftSide")&&(col.tag=="BottomSide"))
        {
            //Destroy(this.gameObject);
            this.gameObject.transform.parent.gameObject.SetActive(false);
        }
    }
}

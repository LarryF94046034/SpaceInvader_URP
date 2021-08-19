using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLaserChild : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "SmallPlaneEnemy")
        {
            CharacterBlood planeStateCtl=col.transform.parent.transform.parent.GetComponent<CharacterBlood>();
            planeStateCtl.planeBloodLogic.ReduceBlood(500);
            //PlayerSkillCtl.Instance.playerBloodLogic.ReduceBlood(100);
            this.gameObject.transform.parent.gameObject.SetActive(false);
        }

        if (col.tag == "Enemy")
        {
            //Destroy(col.gameObject);
            //Debug.Log("HitEnemy");
            this.gameObject.transform.parent.gameObject.SetActive(false);
        }

        if ((col.tag == "TopSide")&&(col.tag=="RightSide")&&(col.tag=="LeftSide")&&(col.tag=="BottomSide"))
        {
            //Destroy(this.gameObject);
            this.gameObject.transform.parent.gameObject.SetActive(false);
        }
    }
}

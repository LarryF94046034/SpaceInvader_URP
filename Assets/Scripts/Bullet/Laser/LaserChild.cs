using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserChild : MonoBehaviour
{
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

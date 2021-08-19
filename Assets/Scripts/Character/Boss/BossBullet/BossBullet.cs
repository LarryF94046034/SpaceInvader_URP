using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBullet : MonoBehaviour
{
    public float damage=100;
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
        if (col.tag == "Ship")
        {
            PlayerSkillCtl.Instance.playerBloodLogic.ReduceBlood(damage);  
        }
        else if((col.tag!="Boss")&&(col.tag!="BossBullet"))
        {
            Destroy(this.gameObject);
        }

        
    }
}

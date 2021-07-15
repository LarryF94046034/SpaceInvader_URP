using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invader : MonoBehaviour
{
    public GameObject explo; //宣告一個名為explo的物件

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += new Vector3(0,-0.01f,0);
    }

    void OnTriggerEnter2D(Collider2D col) //名為col的觸發事件
    {
        //敵人自撞牆壁
        if (col.tag == "BottomSide")
        {
            Destroy(this.gameObject);
        }
        if (col.tag == "Ship")
        {
            PlayerSkillCtl.Instance.playerBloodLogic.ReduceBlood(100);
            Destroy(gameObject); //消滅物件本身
        }

        if (col.tag == "Bullet" ) //如果碰撞的標籤是Ship或Bullet
        {
            Instantiate(explo,transform.position,transform.rotation); //在外星人的位置產生爆炸

            // if (col.tag == "Ship") //如果碰撞的標籤是Ship
            // {
            //     Instantiate(explo,col.gameObject.transform.position,col.gameObject.transform.rotation);
            //     GameFunction.Instance.GameOver(); 
            //     //在碰撞物件的位置產生爆炸，也就是在太空船的位置產生爆炸
            // }
            
            //Destroy(col.gameObject); //消滅碰撞的物件
            Destroy(gameObject); //消滅物件本身

            GameFunction.Instance.AddScore();
        }
    }
}

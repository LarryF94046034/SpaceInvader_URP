using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontShootBehaviour : MonoBehaviour
{
    public SimpleObjectPool colliderPool;
    public float BulletTime; //宣告浮點數，名稱time
    public Vector3 shootPosition_Additive;
    //間隔
    private float shootPerTime;


    void Start()
    {
        if(this.gameObject.tag=="Player")
        {
            shootPerTime=0.5f;
        }
        if(this.gameObject.tag=="SmallPlaneEnemy")
        {
            shootPerTime=3.5f;
        }
    }
    // Update is called once per frame
    void Update()
    {
        ShootBullet();
    }

    public void ShootBullet()
    {
        BulletTime += Time.deltaTime;
        if (BulletTime > shootPerTime && GameFunction.Instance.IsPlaying == true) //每隔0.15秒產生一個子彈
        {
            Vector3 Bullet_pos = this.transform.position + shootPosition_Additive;  //獲得子彈初始位置

            GameObject newBulletCollider=colliderPool.GetOneObject();   //取1子彈Collider

            // newBulletCollider.GetComponent<LaserColliderParent>().BulletSetRotationFromPlane(this.gameObject);    //設定collider轉向
            // newBulletCollider.GetComponent<LaserColliderParent>().SetRotation();

            newBulletCollider.transform.position=Bullet_pos;
            newBulletCollider.transform.position=new Vector3(Bullet_pos.x,Bullet_pos.y,0);  //設定collider初始位置

            newBulletCollider.SetActive(true);  //collider打開

            BulletTime = 0f;
        }
    }
}

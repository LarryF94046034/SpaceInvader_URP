using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateCtl : MonoBehaviour
{
    [Header("子彈")]
    //手機移動與自動射擊
    public GameObject Ship;

    public GameObject Bullet;
    public float BulletTime; //宣告浮點數，名稱time

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ShootBullet();
    }
    public void ShootBullet()
    {
        BulletTime += Time.deltaTime;
        if (BulletTime > 0.15f && GameFunction.Instance.IsPlaying == true) //每隔0.15秒產生一個子彈
        {
            Vector3 Bullet_pos = Ship.transform.position + new Vector3(0, 0.6f, 0);
            Instantiate(Bullet, Bullet_pos, Ship.transform.rotation);
            BulletTime = 0f;
        }
    }

    public GameObject GetPlayer()
    {
        if(this.gameObject==null)
        {
            return null;
        }
        return this.gameObject;
    }
}

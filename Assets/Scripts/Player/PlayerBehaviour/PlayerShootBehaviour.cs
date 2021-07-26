using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootBehaviour : MonoBehaviour
{
    public SimpleObjectPool objectPool;
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
            //Vector3 Bullet_pos = this.transform.position + new Vector3(0, 0.6f, 0);
            Vector3 Bullet_pos = this.transform.position + Vector3.forward*0.6f;
            GameObject newBullet=objectPool.GetOneObject();
            newBullet.GetComponent<Laser>().BulletSetRotationFromPlane(this.gameObject);
            //newBullet.transform.GetChild(0).GetComponent<Laser>().SetRotation(this.gameObject);
            newBullet.SetActive(true);
            newBullet.transform.position=Bullet_pos;
            //Instantiate(Bullet, Bullet_pos, this.transform.rotation);
            BulletTime = 0f;
        }
    }
}

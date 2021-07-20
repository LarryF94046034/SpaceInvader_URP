using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootLogic:MonoBehaviour 
{
    [Header("Circle Shoot")]
    public GameObject bullet;
    public Transform spawnTransform;
    public float bulletSpeed;
    public int divideAngle=12;
    public void CircleShoot()
    {
        StartCoroutine(CircleShooting());
    }
    IEnumerator CircleShooting()
    {
        int n=divideAngle;
        float angle=360;
        for(int i=0;i<n;i++)
        {
            Debug.Log(i);
            GameObject go = Instantiate(bullet, spawnTransform.position,Quaternion.identity);
            Rigidbody2D goRig=go.GetComponent<Rigidbody2D>();
            goRig.velocity=new Vector2(Mathf.Cos(angle/180*Mathf.PI),Mathf.Sin(angle/180*Mathf.PI))*bulletSpeed;
            angle-=360/n*2;
        
            yield return null;
        }
        
    }


    [Header("Circle Rotate Shoot")]
    public GameObject bullet1;
    public Transform spawnTransform1;
    public float bulletSpeed1;
    public int divideAngle1=12;
    public float waitDivideTime=1.0f;
    public int shootAmount;
    public void CircleRotateShoot()
    {
        StartCoroutine(CircleRotateShooting());
    }
    IEnumerator CircleRotateShooting()
    {
        Debug.Log("shoot");
        int n=divideAngle1;
        float angle1=360;
        for(int i=0;i<shootAmount;i++)
        {
            Debug.Log(i);
            GameObject go = Instantiate(bullet1, spawnTransform1.position,Quaternion.identity);
            Rigidbody2D goRig=go.GetComponent<Rigidbody2D>();
            goRig.velocity=new Vector2(Mathf.Cos(angle1/180*Mathf.PI),Mathf.Sin(angle1/180*Mathf.PI))*bulletSpeed;
            //angle1-=360/n*2;
            angle1-=n;

            
        
            yield return new WaitForSeconds(waitDivideTime);
        }
        
    }

    
}

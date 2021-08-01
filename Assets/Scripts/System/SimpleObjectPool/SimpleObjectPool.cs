using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleObjectPool : MonoBehaviour
{
    [Header("池")]
    public List<GameObject> objects=new List<GameObject>();
    public List<bool> objectStates=new List<bool>();
    [Header("設定:GameObject")]
    public GameObject objectGameObject;
    [Header("設定:數量")]
    public int objectNum; 
    [Header("設定:設定父輩，放在下面")]
    public GameObject poolParent; 

    void Start()
    {
        for(int i=0;i<objectNum;i++)
        {
            CreateOneBlock();
        }

        //InvokeRepeating("ReleaseOverPool",0f,3.0f);
    }
    public void CreateOneBlock()    //創造一個物件池空間流程  不管是INITIAL OR OVERPOOL
    {
        GameObject newObject=Instantiate(objectGameObject);  //創造
        newObject.transform.position=new Vector3(0,0,0);
        newObject.transform.SetParent(poolParent.transform);   //放在這物件下
        objects.Add(newObject);   //添LIST GAMEOBJECT
        objectGameObject.SetActive(false);   //該物件SETFALSE
        
    }
    public GameObject GetOneObject()
    {
        int nownum=0;
        for(int i=0;i<objects.Count;i++)
        {
            if(!objects[i].activeInHierarchy)
            {
                return objects[i];
            }
            nownum++;
        }

        // CreateOneBlock();
        // releasePool2.Add(tmpObject);
        // additive++;
        // return tmpObject;

        GameObject notInPool=Instantiate(objectGameObject);
        notInPool.SetActive(false);
        FunctionTimer.Create(()=>
        {
            if(notInPool.activeInHierarchy==false)
            {
                Destroy(notInPool);
            }
        },4.0f);
        return notInPool;

        
        
    }

    
}

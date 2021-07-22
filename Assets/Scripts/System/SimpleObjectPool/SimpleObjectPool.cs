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
    [Header("暫存GObj")]
    public GameObject tmpObject;  
    [Header("暫存額外增加ReleasePool")]
    //public List<GameObject> releasePool=new List<GameObject>();  
    public int additive;
    [Header("暫存往後推倒沒工作的額外ReleasePool")]
    public List<GameObject> releasePool2=new List<GameObject>();  
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
        newObject.transform.SetParent(poolParent.transform);   //放在這物件下
        objects.Add(newObject);   //添LIST GAMEOBJECT
        objectGameObject.SetActive(false);   //該物件SETFALSE
        tmpObject=newObject;
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

    public void ReleaseOverPool()
    {
        if(objects.Count<=objectNum)
        {
            return;
        }

        additive=objects.Count-objectNum;

        // for(int i=0;i<releasePool.Count;i++)
        // {
        //     objects.Remove(releasePool[i]);
        // }
        int counter=0;
        for(int i=objects.Count-10;i>=0;)
        {
            if(objects[i].activeSelf==false)
            {
                objects.Remove(objects[i]);
                releasePool2.Add(objects[i]);
            }
            i--;
            counter++;
            if(counter>=additive-1)
            {
                break;
            }
        }
        for(int i=0;i<releasePool2.Count;i++)
        {
            Destroy(releasePool2[i]);
        }
        releasePool2.Clear();
        additive=0;
    }
}

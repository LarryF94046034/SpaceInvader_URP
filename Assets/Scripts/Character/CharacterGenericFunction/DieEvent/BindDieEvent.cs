using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
public class BindDieEvent : MonoBehaviour
{
    public CharacterBlood characterBlood;
    [SerializeField]
    UnityEvent dieUnityEvent;
    [Header("Destroy")]
    public GameObject destroyObject;
    [Header("Instan")]
    public GameObject instanEffect;
    void Start()
    {
        FunctionTimer.Create(()=>{            //等有bloodLogic再延遲添加 or 改script order
            characterBlood.planeBloodLogic.dieEvent+=InvokeDieUnityEvent;
        },0.1f);
        
    }
    public void InvokeDieUnityEvent()
    {
        dieUnityEvent.Invoke();
    }
    public void DestroySelf()
    {
        Destroy(destroyObject);
    }
    public void InstanEffect()
    {
        Instantiate(instanEffect,destroyObject.transform.position,Quaternion.identity); //在外星人的位置產生爆炸
    }
    public void AddKillAmount()
    {
        GameFunction.Instance.KillAmount++;
    }

    // Start is called before the first frame update
    
}

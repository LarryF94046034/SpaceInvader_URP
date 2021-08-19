using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveLooping : MonoBehaviour
{
    public Vector3 directionVector;
    public float duration;
    public Vector3 originalLocalPos;
    bool firstTime=false;


    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void RePosition()
    {
        
    }
    public void Move()
    {
        Debug.Log("Move");
        transform.position=originalLocalPos;
        transform.DOMove(directionVector,duration).SetEase(Ease.Linear);
    }

    // Update is called once per frame
    void Update()
    {
        if(firstTime==false)
        {
            transform.DOMove(directionVector,duration).SetEase(Ease.Linear);
            firstTime=true;
        }
        
        timer+=Time.deltaTime;
        if(timer>=duration)
        {
            transform.DOPause();
            transform.position=originalLocalPos;
            transform.DOMove(directionVector,duration).SetEase(Ease.Linear);
            timer=0;
        }
    }
}

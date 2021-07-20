using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossLeftStateCtl : MonoBehaviour
{
    public static BossLeftStateCtl Instance;
    public GameObject Boss;
    

    public float timer;

    [Header("Shoot Class")]         
    public ShootLogic shootLogic;
    
    
    [Header("BOSS CIRCLE SHOOT DATA")]    //circle shoot
    public GameObject circleShoot;

    
    [Header("BOSS CIRCLE RO SHOOT DATA")]    //circle rotate shoot
    public GameObject circleRotateShoot;
    void Awake()
    {
        Instance=this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer+=Time.deltaTime;
    }

    public void DebugOne()
    {
        Debug.Log("One");
    }
}

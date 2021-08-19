using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCycle : MonoBehaviour
{
    bool update=false;
    bool fixupdate=false;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        if(update==false)
        {
            Debug.Log("Update");
            update=true;
        }
    }

    void FixedUpdate()
    {
        if(fixupdate==false)
        {
            Debug.Log("FixUpdate");
            fixupdate=true;
        }
    }

    void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    void OnDisable()
    {
        Debug.Log("OnDiable");
    }

    void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediatorSetManager : MonoBehaviour
{
    static MediatorSetManager _instance;
    public static MediatorSetManager Instance{
        get{
            if (_instance == null){
                _instance = FindObjectOfType(typeof(MediatorSetManager)) as MediatorSetManager;
                if (_instance == null){
                    GameObject go = new GameObject("MediatorSetManager");
                    _instance = go.AddComponent<MediatorSetManager>();
                }
            }
            return _instance;
        }
    }
    
    void Start()
    {

    }
    public void PassRotation(GameObject settedObj,GameObject toSetObj)
    {
        settedObj.transform.rotation=toSetObj.transform.rotation;
    }
}

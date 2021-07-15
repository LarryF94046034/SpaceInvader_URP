using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateCtl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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

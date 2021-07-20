using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    public float time=3.0f;
    // Start is called before the first frame update
    void Start()
    {
        
        //Destroy(this.gameObject,time);
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AnimationEnd() 
    {
        Destroy (gameObject); //消滅物件
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EqualPosition : MonoBehaviour
{
    public GameObject equalObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position=equalObject.transform.position;
        this.transform.eulerAngles=new Vector3(equalObject.transform.eulerAngles.x,90,0);
    }
}

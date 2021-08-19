using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSingleObject : MonoBehaviour
{
    public Vector3 rotateEuler;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateEuler,Space.Self);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintValue : MonoBehaviour
{
    public CanvasScaler canvasScaler;
    // Start is called before the first frame update
    void Start()
    {
        Resolution[] resolutions = Screen.resolutions;

        foreach (var res in resolutions)
        {
            Debug.Log(res.width + "x" + res.height + " : " + res.refreshRate);
        }

        Debug.Log("SH:"+Screen.height);
        Debug.Log("SW:"+Screen.width);

        Debug.Log("CSX:"+canvasScaler.referenceResolution.x);
        Debug.Log("CSY:"+canvasScaler.referenceResolution.y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

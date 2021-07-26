using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScreenSizeSystem : MonoBehaviour
{
    public CanvasScaler canvasScaler;
    void Awake()
    {
        canvasScaler.referenceResolution=new Vector2(Screen.width,Screen.height);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

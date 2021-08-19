using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallPlaneStateCtl : MonoBehaviour
{
    [Header("SmallPlaneBloodLogic")]
    public BloodLogicWithSprite planeBloodLogic;
    public float maxHealth;
    public float maxBloodSpriteWidth;
    public SpriteRenderer planeBloodSpriteRen;
    // Start is called before the first frame update
    void Start()
    {
        BindPlayerBloodEvent();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BindPlayerBloodEvent()
    {
        planeBloodLogic=new BloodLogicWithSprite(planeBloodSpriteRen,maxHealth,1);
    }
}

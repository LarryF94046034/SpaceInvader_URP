using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using System;

public class CharacterBlood : MonoBehaviour
{
    [Header("BloodLogic")]
    public BloodLogicWithSprite planeBloodLogic;
    [Header("Data")]
    public float maxHealth;
    public float maxBloodSpriteWidth;
    [Header("Set")]
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

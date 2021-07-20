using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystems : MonoBehaviour
{
    public static GameSystems Instance;
    //Player
    [Header("Player")]
    public PlayerSkillCtl playerSkillCtl;
    public PlayerStateCtl playerStateCtl;
    //Effects
    [Header("Effects")]
    public EffectSystem effectSystem;
    //Systems
    [Header("Systems")]
    public GameEventSystem gameEventSystem;
    public TimelineControllerSystem timelineControllerSystem;
    
    //Logic
    [Header("Logic")]
    public ShootLogic bossLeftShootLogic;
    void Awake()
    {
        Instance=this;
    }
}

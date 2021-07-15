using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystems : MonoBehaviour
{
    public static GameSystems Instance;
    //Player
    public PlayerSkillCtl playerSkillCtl;
    public PlayerStateCtl playerStateCtl;
    //Effects
    public EffectSystem effectSystem;
    //Systems
    public GameEventSystem gameEventSystem;

    void Awake()
    {
        Instance=this;
    }
}

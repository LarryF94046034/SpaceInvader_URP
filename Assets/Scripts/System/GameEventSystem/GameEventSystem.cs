using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEventSystem : MonoBehaviour
{
    public void PlayerDie()
    {
        if(GameSystems.Instance.playerStateCtl.GetPlayer()==null)
        {
            return;
        }
        Destroy(GameSystems.Instance.playerStateCtl.GetPlayer());

        Instantiate(GameSystems.Instance.effectSystem.explodeObject,          //explodeObject
        GameSystems.Instance.playerStateCtl.GetPlayer().transform.position,   //playerPos
        GameSystems.Instance.playerStateCtl.GetPlayer().transform.rotation); //在玩家的位置產生爆炸    //playerRot

        GameFunction.Instance.GameOver();
    }
}

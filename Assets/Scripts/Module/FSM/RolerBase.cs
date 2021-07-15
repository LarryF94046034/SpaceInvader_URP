using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RolerBase : MonoBehaviour
{
    protected FSMManager fSMManager;      //暫時protected改public

    public enum AnimationEnum
    {
        StateStraw,
        StateBanana,
        StateWatermelon,
        StatePineapple,
        StateOrange,
        StateEnding,
        Max
    }

    public virtual void Initial()
    {
        fSMManager = new FSMManager((int)AnimationEnum.Max);


    }



    public virtual void ChangeState(sbyte state)
    {
        fSMManager.ChangeState(state);
    }

    public virtual bool CheckEqualState(sbyte state)
    {
        return fSMManager.CheckEqualState(state);
    }



    public virtual void Stay()
    {
        if (fSMManager != null)
        {
            fSMManager.Stay();
        }
    }
    public void CheckNotEqualState(sbyte state)
    {
        if (fSMManager != null)
        {
            fSMManager.CheckNotEqualState(state);
        }
    }
}


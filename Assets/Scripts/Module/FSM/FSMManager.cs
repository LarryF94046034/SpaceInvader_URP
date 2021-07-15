using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSMManager : MonoBehaviour
{
    FSMBase[] allState;
    #region Initial
    public void Initial(int stateCount)
    {
        allState = new FSMBase[stateCount];
    }
    public FSMManager(int stateCount)
    {
        Initial(stateCount);
    }
    #endregion

    sbyte stateIndex = -1;//當前
    sbyte curState = -1; //已裝多少
    public void AddState(FSMBase tmpBase)
    {
        if (curState > allState.Length)
        {
            return;
        }
        curState++;
        allState[curState] = tmpBase;
    }

    public void ChangeState(sbyte index)
    {
        if (stateIndex != -1)
        {
            allState[stateIndex].OnExit();
        }
        stateIndex = index;
        allState[stateIndex].OnEnter();
    }

    public void Stay()
    {
        if (stateIndex != -1)
        {
            allState[stateIndex].OnStay();
        }
    }

    public bool CheckNotEqualState(sbyte index)
    {
        if (stateIndex != index)
        {
            return true;
        }
        return false;
    }

    public bool CheckEqualState(sbyte index)
    {
        if (stateIndex == index)
        {
            return true;
        }
        return false;
    }





}

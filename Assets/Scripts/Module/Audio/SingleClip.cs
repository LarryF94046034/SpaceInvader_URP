using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleClip : MonoBehaviour
{
    AudioClip myClip;
    public SingleClip(AudioClip tmpClip)
    {
        myClip = tmpClip;
    }


    public void Play(AudioSource tmpSource)   //賦予空source clip並播放
    {
        tmpSource.clip = myClip;
        tmpSource.Play();
    }
}

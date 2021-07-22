using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SourceManager : MonoBehaviour
{


    List<AudioSource> allSource;

    GameObject owner;


    public SourceManager(GameObject tmpOwner)
    {
        owner = tmpOwner;
        Initial();
    }


    public void Initial()
    {
        allSource = new List<AudioSource>();
        for (int i = 0; i < 3; i++)       //塞3音效COMPO
        {
            AudioSource tmpSource = owner.AddComponent<AudioSource>();
            allSource.Add(tmpSource);
        }
    }





    public AudioSource GetFreeAudio()
    {
        for (int i = 0; i < allSource.Count; i++)   //從頭到尾，(3個)誰沒播放，回傳他
        {
            if (!allSource[i].isPlaying)
                return allSource[i];
        }

        AudioSource tmpSource = owner.AddComponent<AudioSource>();       //都在播放new(會一直增大，需要Free)
        allSource.Add(tmpSource);
        return tmpSource;
    }

    public void ReleaseFreeAudio()
    {
        int tmpCount = 0;
        List<AudioSource> tmpSources = new List<AudioSource>();
        for (int i = 0; i < allSource.Count; i++)     //判斷誰是多餘的，檢查所有，超過三個沒在播的塞入緩存陣列
        {
            if (!allSource[i].isPlaying)
            {
                tmpCount++;

            }

            if (tmpCount > 3)
            {
                tmpSources.Add(allSource[i]);
            }

        }


        for (int i = 0; i < tmpSources.Count; i++)   //緩存內全移除及銷毀
        {
            AudioSource tmpSource = tmpSources[i];
            allSource.Remove(tmpSource);
            GameObject.Destroy(tmpSource);
        }

        tmpSources.Clear();     //緩存陣列清空
        tmpSources = null;

    }


    public void Stop(string audioName)
    {
        for (int i = 0; i < allSource.Count; i++)
        {
            if (allSource[i].isPlaying && allSource[i].clip.name.Equals(audioName))
            {
                allSource[i].Stop();
                ReleaseFreeAudio();
            }
        }
    }

    public void Pause(string audioName)
    {
        for (int i = 0; i < allSource.Count; i++)
        {
            if (allSource[i].isPlaying && allSource[i].clip.name.Equals(audioName))
            {
                allSource[i].Pause();

            }
        }
    }
    public void Continue(string audioName)
    {
        for (int i = 0; i < allSource.Count; i++)
        {
            if (!allSource[i].isPlaying && allSource[i].clip.name.Equals(audioName))
            {
                allSource[i].Play();
                break;
            }
        }
    }
}

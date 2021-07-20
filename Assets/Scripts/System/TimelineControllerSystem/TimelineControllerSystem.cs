using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//timeline
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class TimelineControllerSystem : MonoBehaviour
{
    public List<PlayableDirector> playableDirectors;
    public List<TimelineAsset> timelines;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        foreach (PlayableDirector playableDirector in playableDirectors) 
        {
            playableDirector.Play ();
        }
    }

    public void PlayFromTimelines(int index)
    {
        TimelineAsset selectedAsset;

        if (timelines.Count <= index) 
        {
            selectedAsset = timelines [timelines.Count - 1];
        } 
        else 
        {
            selectedAsset = timelines [index];
        }

        playableDirectors [0].Play (selectedAsset);
    }
}

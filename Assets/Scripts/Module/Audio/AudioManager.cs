using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    SourceManager sourceManager;
    ClipManager clipManager;
    public static AudioManager Instance;
    private void Start()
    {
        Instance = this;
        sourceManager = new SourceManager(gameObject);  //AudioSource掛在這
        clipManager = new ClipManager();  //AudioSource掛在這
    }

    public void Play(string audioName)
    {
        AudioSource tmpSource = sourceManager.GetFreeAudio();
        SingleClip tmpClips = clipManager.FindClipByName(audioName);
        tmpClips.Play(tmpSource);

    }

    public void Stop(string audioName)
    {
        sourceManager.Stop(audioName);
    }

    public void Pause(string audioName)
    {
        sourceManager.Pause(audioName);
    }
    public void Continue(string audioName)
    {
        sourceManager.Continue(audioName);
    }


    public void PlayUntil(string audioName,float until)
    {
        AudioSource tmpSource = sourceManager.GetFreeAudio();
        SingleClip tmpClips = clipManager.FindClipByName(audioName);
        tmpClips.Play(tmpSource);

        FunctionTimer.Create(() => { sourceManager.Stop(audioName); }, until);


    }
}

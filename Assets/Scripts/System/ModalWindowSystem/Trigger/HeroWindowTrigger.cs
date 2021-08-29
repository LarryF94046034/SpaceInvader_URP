using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;

public class HeroWindowTrigger : MonoBehaviour
{
    public string title;
    public Sprite sprite;
    public string message;
    public bool triggerOnEnable;

    public UnityEvent onContinueCallback;
    public UnityEvent onCancelCallback;
    public UnityEvent onAlternateCallback;

    public UnityEvent onContinueEvent;
    public UnityEvent onCancelEvent;
    public UnityEvent onAlternateEvent;
    
    public void Enable()
    {
        if(!triggerOnEnable)
        {
            return;
        }

        Action continueCallback=null;
        Action cancelCallback=null;
        Action alternateCallback=null;

        if(onContinueCallback.GetPersistentEventCount()>0)
        {
            continueCallback=onContinueEvent.Invoke;
        }
        if(onCancelCallback.GetPersistentEventCount()>0)
        {
            cancelCallback=onCancelEvent.Invoke;
        }
        if(onAlternateCallback.GetPersistentEventCount()>0)
        {
            alternateCallback=onAlternateEvent.Invoke;
        }

        UIController.Instance.modalWindow.ShowAsHero(title,sprite,message,null,null,null);
    }
}

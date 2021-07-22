using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseAudio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            AudioManager.Instance.Play("One");
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            AudioManager.Instance.Stop("One");
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            AudioManager.Instance.Pause("One");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            AudioManager.Instance.Continue("One");
        }
    }
}

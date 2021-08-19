using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UnityAPI_ChangeScene : MonoBehaviour
{
    static UnityAPI_ChangeScene _instance;
    public static UnityAPI_ChangeScene Instance{
        get{
            if (_instance == null){
                _instance = FindObjectOfType(typeof(UnityAPI_ChangeScene)) as UnityAPI_ChangeScene;
                if (_instance == null){
                    GameObject go = new GameObject("UnityAPI_ChangeScene");
                    _instance = go.AddComponent<UnityAPI_ChangeScene>();
                }
            }
            return _instance;
        }
    }
    
    void Start()
    {

    }

    public void LoadSceneWithName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}

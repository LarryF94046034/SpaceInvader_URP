using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
public class ClipManager : MonoBehaviour
{
    public ClipManager()
    {
        ReadConfig();
        LoadClips();
    }
    string[] clipName = { "", "", "" };
    public void ReadConfig()
    {
        var fileAddress = System.IO.Path.Combine(Application.streamingAssetsPath, "AudioConfig.txt");
        FileInfo fInfo0 = new FileInfo(fileAddress);
        if (fInfo0.Exists)
        {
            Debug.Log("1");
            StreamReader r = new StreamReader(fileAddress);
            string tmpLine = r.ReadLine();  //讀取第一行，取得讀取行數

            int lineCount = 0;
            if (int.TryParse(tmpLine, out lineCount))  //轉換第一行string->int
            {
                clipName = new string[lineCount];
                for (int i = 0; i < lineCount; i++)
                {
                    tmpLine = r.ReadLine();  //讀三行
                    string[] splits = tmpLine.Split(" ".ToCharArray());
                    clipName[i] = splits[0];
                    //Debug.Log(splits[0]);
                    //Debug.Log(splits[1]);


                }

                r.Close();
            }

        }
    }

    SingleClip[] allSingleClip;
    public void LoadClips()  //加載Clip到內存
    {

        allSingleClip = new SingleClip[clipName.Length];      //創實體Clip跟實體Class存點
        for (int i = 0; i < clipName.Length; i++)
        {
            AudioClip tmpClip = Resources.Load<AudioClip>(clipName[i]);  //取Clip資源
            //Debug.Log("clip==" + tmpClip.name);
            SingleClip tmpSingle = new SingleClip(tmpClip);    //new SingleClip
            allSingleClip[i] = tmpSingle;                      //存入allSingleClip

        }

    }


    public SingleClip FindClipByName(string tmpName)
    {
        int tmpIndex = -1;
        Debug.Log(tmpName);
        for (int i = 0; i < clipName.Length; i++)
        {
            if (clipName[i].Equals(tmpName))
            {
                tmpIndex = i;
            }
        }

        if (tmpIndex != -1)
        {
            return allSingleClip[tmpIndex];
        }
        return null;

    }
}

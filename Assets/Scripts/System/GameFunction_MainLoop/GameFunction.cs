using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //使用UI

public class GameFunction : MonoBehaviour
{
    //單利
    public static GameFunction Instance; // 設定Instance，讓其他程式能讀取GameFunction裡的東西
    public GameObject Emeny; //宣告物件，名稱Emeny
    public float time; //宣告浮點數，名稱time
    public float BulletTime; //宣告浮點數，名稱time
    
    //記分板
    public Text ScoreText; //宣告一個ScoreText的text

    public int Score = 0; // 宣告一整數 Score
    //單例

    [Header("Text")]
    //起始文字提示
    public GameObject GameTitle; //宣告GameTitle物件

    public GameObject GameOverTitle; //宣告GameOverTitle物件
    public GameObject GameWinTitle; //宣告GameWinTitle物件

    
    [Header("IsPlaying")]
    public bool IsPlaying = false; // 宣告IsPlaying 的布林資料，並設定初始值false
    [Header("Button")]
    public GameObject PlayButton; //宣告PlayButton物件
    //重新開始及離開
    public GameObject RestartButton; //重新這關遊戲Btn

    public GameObject QuitButton; //離開遊戲Btn
    public GameObject ContinueButton; //下一關Btn
    [Header("KillAmount")]
    public int killAmountMax;
    private int killAmount;
    public int KillAmount
    {
        get
        {
            return killAmount;
        }
        set
        {
            killAmount=value;
            if(killAmount==killAmountMax)
            {
                CompleteLevel();
            }
        }
    }
    

    // Start is called before the first frame update
    void Start()
    {
        Instance = this; //指定Instance這個程式

        GameTitle.SetActive(true); //設定GameTitle顯示

        GameOverTitle.SetActive(false); //設定GameOverTitle不顯示
        RestartButton.SetActive(false); //RestartButton設定成不顯示


        GameStart();
    }

    // Update is called once per frame
    void Update()
    {
        // time += Time.deltaTime; //時間增加
        // if(time>0.5f && IsPlaying == true) //如果時間大於0.5(秒)
        // {
        //     Vector3 pos = new Vector3(Random.Range(-2.5f,2.5f),4.5f,0); //宣告位置pos，Random.Range(-2.5f,2.5f)代表X是2.5到-2.5之間隨機
        //     Instantiate(Emeny,pos,transform.rotation);//產生敵人
        //     time = 0f; //時間歸零
        // }


        
    }

    public void AddScore()
    {

        Score += 10; //分數+10

        ScoreText.text = "Score: " + Score; // 更改ScoreText的內容

    }

    public void GameStart() 
    {
        Debug.Log("Play");
        IsPlaying = true; //設定IsPlaying為true，代表遊戲正在進行中

        GameTitle.SetActive (false); //不顯示GameTitle

        PlayButton.SetActive (false); //不顯示PlayButton
        QuitButton.SetActive (false); //QuitButton設定成不顯示

        GameSystems.Instance.timelineControllerSystem.Play();

    }

    public void GameOver() //GameOver的Function
    {

        IsPlaying = false; //IsPlaying設定成false，停止產生外星人

        GameOverTitle.SetActive(true); //設定為ture，顯示GameOverTitle
        RestartButton.SetActive(true); //RestartButton設定成顯示

        QuitButton.SetActive(true); //QuitButton設定成顯示

    }

    public void ResetGame() //RestartButton的功能
    {

        Application.LoadLevel (Application.loadedLevel); //讀取關卡(已讀取的關卡)

    }
    public void QuitGame() //QuitButton的功能
    {

        Application.Quit(); //離開應用程式

    }
    #region Level One
    public void CompleteLevel()
    {
        IsPlaying = false; //IsPlaying設定成false，停止產生外星人

        GameWinTitle.SetActive(true); //設定為ture，顯示GameOverTitle
        RestartButton.SetActive(true); //RestartButton設定成顯示
        ContinueButton.SetActive(true); //ContinueButton設定成顯示

    }
    #endregion
}

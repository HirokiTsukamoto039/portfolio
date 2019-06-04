using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMain : MonoBehaviour {

    public static bool GameStartFlag;
    private float CollTime;
    private float GameOverTime;
    private float NowTime;
    public static Text TimerText;
    private Text CollTimeText;
    private Text GameOverText;
    public static bool PlayerGameOverFlag;
    private bool ResultFlag;
    public static int PlayTime;
    public static float RnkingTime;
    private float GameOverLine;

    void Start ()
    {
        StartTimer();

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        GameStartFlag = false;
        ResultFlag = false;
        PlayerGameOverFlag = false;
        GameObject.Find("Coll").SetActive(true);
        GameOverText = GameObject.Find("GameOver").GetComponentInChildren<Text>();
        GameOverLine = GamaLoopManager.InputValueFloor * BlockController.FloorSpace;

    }
	
	void Update ()
    {
        if(!GameStartFlag)
        {
            GameStartColl();
        }
        else if(GameStartFlag)
        {

            if(!PlayerGameOverFlag)
            {
                UpdateTimer();
                PlayerGameOver();
            }

            if(PlayerGameOverFlag && !ResultFlag)
            {
                ResultTransition();
            }
        }

    }

    private void GameStartColl()
    {
        CollTime += Time.deltaTime;
        if(CollTime >= 5.0f)
        {
            Gamestart();
        }
        else if (CollTime >= 4.0f)
        {
            CollTimeText.text = "ＧＯ！";
        }
        else if (CollTime >= 3.0f)
        {
            CollTimeText.text = "１";
        }
        else if (CollTime >= 2.0f)
        {
            CollTimeText.text = "２";
        }
        else if (CollTime >= 1.0f)
        {
            CollTimeText.text = "３";
        }
    }

    private void Gamestart()
    {
        GameStartFlag = true;
        GameObject.Find("Coll").SetActive(false);
    }

    private void StartTimer()
    {
        NowTime = 0;
        TimerText = GameObject.Find("Timer").GetComponentInChildren<Text>();
        CollTimeText = GameObject.Find("Coll").GetComponentInChildren<Text>();
        GameOverTime = 0;
        RnkingTime = 0;
    }

    private void UpdateTimer()
    {
        NowTime += Time.deltaTime;

        TimerText.text = ConvertTime(NowTime);
    }

    private string ConvertTime(float time)
    {
        int Seconds = Convert.ToInt32(time % 60);
        int Minute = Convert.ToInt32(Math.Floor(time / 60.0f));
        string TimeTextString;

        if(Seconds >= 60)
        {
            Seconds = 0;
            Minute++;
        }

        TimeTextString = "Time " + Minute.ToString("00") + ":" + Seconds.ToString("00");

        return TimeTextString;
    }
    

    private void PlayerGameOver()
    {
        if(GameObject.Find("Player").transform.position.y <= -GameOverLine - 10)
        {
            GameOverText.text = "Game Over";
            PlayerGameOverFlag = true;
        }

    }

    private void ResultTransition()
    {
        GameOverTime += Time.deltaTime;
        if(GameOverTime >= 4.0f)
        {
            ResultFlag = true;
            PlayTime = Convert.ToInt32(NowTime);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene("Scene/Result");
        }
    }

}

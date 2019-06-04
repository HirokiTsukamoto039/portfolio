using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultManager : MonoBehaviour {

    private Text PlayerName;
    private Text FloorNumber;
    private Text Time;

    public static string NameResultText;
    public static string FloorResultText;
    public static string TimeResultText;

    private void Start()
    {
        PlayerName = GameObject.Find("Name").GetComponentInChildren<Text>();
        FloorNumber = GameObject.Find("Floor").GetComponentInChildren<Text>();
        Time = GameObject.Find("Time").GetComponentInChildren<Text>();
        PlayerName.text = GamaLoopManager.PlayerName;
        FloorNumber.text = GamaLoopManager.FloorNumber;
        Time.text = ConvertTime(GameMain.PlayTime);

        NameResultText = PlayerName.text;
        FloorResultText = FloorNumber.text;
        TimeResultText = GameMain.PlayTime.ToString();
    }

    private string ConvertTime(int time)
    {
        int Seconds = Convert.ToInt32(time % 60);
        int Minute = Convert.ToInt32(Math.Floor(time / 60.0f));
        string TimeTextString;

        if (Seconds >= 60)
        {
            Seconds = 0;
            Minute++;
        }

        TimeTextString = "Time " + Minute.ToString("00") + ":" + Seconds.ToString("00");

        return TimeTextString;
    }
}

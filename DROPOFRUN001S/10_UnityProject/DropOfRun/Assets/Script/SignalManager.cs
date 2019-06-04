using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class SignalManager : MonoBehaviour
{
    [SerializeField] public Text RankingNameText;
    [SerializeField] public Text RankingFloorText;
    [SerializeField] public Text RankingTimeText;
    [SerializeField] public Text RankingAverageTimeText;

    [SerializeField] public Text RankingTitleText;

    public static string RankingTextText;

    private bool RankingRoadFlag;

    private bool GetAllRecordFlag;

    private int count;

    List<RankingData> MemberList = null;


    private void Start()
    {
        OnGetJsonFromWww();
        RankingRoadFlag = false;
        count = 0;
    }

    private void Update()
    {
        if(!RankingRoadFlag)
        {
            ShowMemberList();
            if(count > 30)
            {
                RankingRoadFlag = true;
            }
            count++;
        }
    }

    public void OnClickGetRanking()
    {
        GetAllRecordFlag = true;
        Debug.Log("AllGetRecord");
        OnGetJsonFromWww();
    }

    public void OnGetJsonFromWww()
    {

        Debug.Log("wait...");
        GetJsonFromWww();

    }

    public void OnClickGetSelectJsonFromWww()
    {
        if(RankingManager.InputFieldSelectFloor.text == "" || RankingManager.InputFieldSelectFloor.text =="-" || int.Parse(RankingManager.InputFieldSelectFloor.text) <= 0)
        {
            CallbackWwwFailed();
            return;
        }
        Debug.Log("wait...");
        GetJsonFromWww();
    }
    
    private void ShowMemberList()
    {

        string sStrOutput = "";

        string NameOutput = "";
        string FloorOutput = "";
        string TimeOutput = "";
        string AverageTimeOutput = "";
        

        if (null == MemberList)
        {
            sStrOutput = "no list !";
        }
        else
        {
            foreach (RankingData MemberOne in MemberList)
            {
                sStrOutput += string.Format("Name:{0} Floor:{1} Time:{2}  AverageTime:{3}\n",
                    MemberOne.Name, MemberOne.Floor, ConvertTime(MemberOne.Time), ConvertTime(Math.Floor(MemberOne.AverageTime)));

                NameOutput += string.Format("{0}\n", MemberOne.Name);
                

                FloorOutput += string.Format("{0}\n", MemberOne.Floor);
                TimeOutput += string.Format("{0}\n", ConvertTime(MemberOne.Time));
                AverageTimeOutput += string.Format("{0}\n", ConvertTime(Math.Floor(MemberOne.AverageTime)));
            }
            
        }
        
        Debug.Log(sStrOutput);

        if(NameOutput == "")
        {
            NameOutput = "Not Record";
        }

        RankingNameText.text = NameOutput;
        RankingFloorText.text = FloorOutput;
        RankingTimeText.text = TimeOutput;
        RankingAverageTimeText.text = AverageTimeOutput;

    }

    private string ConvertTime(double time)
    {
        int Seconds = Convert.ToInt32(time % 60);
        int Minute = Convert.ToInt32(Math.Floor(time / 60.0f));
        string TimeTextString;

        if (Seconds >= 60)
        {
            Seconds = 0;
            Minute++;
        }

        TimeTextString = Minute.ToString("00") + ":" + Seconds.ToString("00");

        return TimeTextString;
    }

    private void GetJsonFromWww()
    {
        ResetRankingText();
        // APIが設置してあるURLパス
        string sTgtURL = "http://localhost/DropOfRunRankingAverage/Dropofrunrankingaverage/getRanking/";


        StartCoroutine(
            DownloadJson(
                sTgtURL,
                CallbackWwwSuccess,
                CallbackWwwFailed
            )
        );

    }
    

    private void ResetRankingText()
    {
        RankingNameText.text = "";
        RankingFloorText.text = "";
        RankingTimeText.text = "";
        RankingAverageTimeText.text = "";
    }

    private void CallbackWwwSuccess(string response)
    {
        MemberList = RankingDataModel.DesirializeFromJson(response);

        Debug.Log("Success!");
        RankingRoadFlag = false;

        RankingManager.RankingDisplay();
    }
    
    private void CallbackWwwFailed()
    {
        Debug.Log("Www Failed");
    }

    
    private IEnumerator DownloadJson(string sTgtURL, Action<string> cbkSuccess = null, Action cbkFailed = null)
    {
        WWWForm form = new WWWForm();

        if(!GetAllRecordFlag)
        {
            form.AddField("Floor", RankingManager.InputValueSelectFloor);
        }
        else
        {
            form.AddField("Floor", "");
            GetAllRecordFlag = false;
        }

        WWW www = new WWW(sTgtURL, form);
        
        yield return StartCoroutine(ResponceCheckForTimeOutWWW(www, 5.0f));

        if (www.error != null)
        {
            Debug.LogError(www.error);
            if (null != cbkFailed)
            {
                cbkFailed();
            }
        }
        else
        if (www.isDone)
        {
            Debug.Log(string.Format("Success:{0}", www.text));
            if (null != cbkSuccess)
            {
                cbkSuccess(www.text);
            }
        }
    }
    
    private IEnumerator ResponceCheckForTimeOutWWW(WWW www, float timeout)
    {
        float requestTime = Time.time;

        while (!www.isDone)
        {
            if (Time.time - requestTime < timeout)
            {
                yield return null;
            }
            else
            {
                Debug.LogWarning("TimeOut");
                break;
            }
        }
        yield return null;

    }

}
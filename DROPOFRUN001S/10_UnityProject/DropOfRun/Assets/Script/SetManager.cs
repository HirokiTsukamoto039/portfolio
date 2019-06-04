using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MiniJSON;		// Json
using System;		// File

public class SetManager : MonoBehaviour {

    private void Start()
    {
        SetJsonFromWww();
    }


    private void SetJsonFromWww()
    {
        // APIが設置してあるURLパス
        string sTgtURL = "http://localhost/DropOfRunRankingAverage/Dropofrunrankingaverage/setRanking/";

        StartCoroutine(
        UploadJson(
            sTgtURL,
            CallbackWwwSuccess,
            CallbackWwwFailed
            )
        );
    }


    private void CallbackWwwSuccess(string response)
    {
        Debug.Log("Www Success");
        Debug.Log(response);
    }

    private void CallbackWwwFailed()
    {
        Debug.Log("Www Failed");
    }

    private IEnumerator UploadJson(string sTgtURL, Action<string> cbkSuccess = null, Action cbkFailed = null)
    {
        WWWForm form = new WWWForm();

        form.AddField("Name", ResultManager.NameResultText);
        form.AddField("Floor", ResultManager.FloorResultText);
        form.AddField("Time", ResultManager.TimeResultText);
        form.AddField("AverageTime", Convert.ToInt32(ResultManager.TimeResultText) / Convert.ToInt32(ResultManager.FloorResultText));

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

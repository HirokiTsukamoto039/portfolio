using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameTagManager : MonoBehaviour {

    // ビルボード処理
    private RectTransform myRectTfm;

    private Text PlayerNameTag;
    
    void Start ()
    {
        PlayerNameTag = GameObject.Find("PlayerNameTag").GetComponent<Text>();
        PlayerNameTag.text = GamaLoopManager.PlayerName;
        myRectTfm = GetComponent<RectTransform>();
	}
	
	void Update ()
    {
        myRectTfm.LookAt(Camera.main.transform);
        myRectTfm.Rotate(new Vector3(0, -180, 0));
	}
}

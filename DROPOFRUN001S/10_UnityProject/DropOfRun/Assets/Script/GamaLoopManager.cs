using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GamaLoopManager : MonoBehaviour {

    public static InputField InputFieldName;

    public static InputField InputFieldFloor;

    public string InputValueName;

    public static int InputValueFloor;

    public static string PlayerName;

    public static string FloorNumber;


    private void Start()
    {
        if (GameObject.Find("InputPlayerName"))
        {
            InputFieldName = GameObject.Find("InputPlayerName").GetComponent<InputField>();

            InputLogerName();
        }

        if(GameObject.Find("InputFloorNumber"))
        {
            InputFieldFloor = GameObject.Find("InputFloorNumber").GetComponent<InputField>();

            InputLogerFloor();
        }

    }

    private void Update()
    {
        InputLogerName();
        InputLogerFloor();
        if (Input.GetKey(KeyCode.Escape))
        {
            Quit();
        }
    }


    public void InputLogerName()
    {
        if (!GameObject.Find("InputPlayerName"))
        {
            return;
        }
        else
        {
            InputValueName = InputFieldName.text;
        }
    }

    public void InputLogerFloor()
    {
        if(!GameObject.Find("InputFloorNumber") || InputFieldFloor.text == "" || InputFieldFloor.text == "-")
        {
            return;
        }
        else
        {
            InputValueFloor = Convert.ToInt32(InputFieldFloor.text);
        }
    }
    

    public void OnClickGameRoomButton()
    {
        SceneManager.LoadScene("Scene/GameRoom");
    }

    public void OnClickRankingButton()
    {
        SceneManager.LoadScene("Scene/Ranking");
    }

    public void OnClickBackHomeButton()
    {
        SceneManager.LoadScene("Scene/Home");
    }

    public void OnClickGameStartButton()
    {
        if(InputValueFloor > 0 && InputFieldFloor.text != "" && InputFieldFloor.text != "-")
        {
            if (InputValueName == "")
            {
                InputFieldName.text = "NoName";
            }
            PlayerName = InputFieldName.text;
            FloorNumber = InputFieldFloor.text;
            SceneManager.LoadScene("Scene/Game");
        }
    }

    public void OnClickEnd()
    {
        Quit();
    }

    void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_STANDALONE
    UnityEngine.Application.Quit();
#endif
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RankingManager : MonoBehaviour {

    public static InputField InputFieldSelectFloor;

    public static string InputValueSelectFloor;

    private void Start()
    {
        if (GameObject.Find("SelectFloor"))
        {
            InputFieldSelectFloor = GameObject.Find("SelectFloor").GetComponent<InputField>();
            InputLogerSelectFloor();
        }
    }

    private void Update()
    {
        InputLogerSelectFloor();
    }

    public static void RankingDisplay()
    {
        SignalManager.RankingTextText = "%d,%d,%d";

    }

    private void InputLogerSelectFloor()
    {
        if (!GameObject.Find("SelectFloor"))
        {
            return;
        }
        else
        {
            InputValueSelectFloor = InputFieldSelectFloor.text;
        }
    }

}

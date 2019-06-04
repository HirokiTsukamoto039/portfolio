using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRoomManager : MonoBehaviour {

    public GameObject TipsButton;

    public GameObject TipsText;

    public GameObject TipsPanel;
    

    public void OnClickTipsOffButton()
    {
        TipsButton.SetActive(false);
        TipsText.SetActive(false);
        TipsPanel.SetActive(false);
    }

    public void OnClickTipsOnButton()
    {
        TipsButton.SetActive(true);
        TipsText.SetActive(true);
        TipsPanel.SetActive(true);
    }
}

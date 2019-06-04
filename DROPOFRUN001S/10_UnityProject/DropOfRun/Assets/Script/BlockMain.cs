using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMain : MonoBehaviour {

    private bool DestroyFlag;

    void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.CompareTag("Player") && !DestroyFlag && GameMain.GameStartFlag)
        {
            DestroyFlag = true;
            Destroy(gameObject, 0.5f);
        }
    }
}

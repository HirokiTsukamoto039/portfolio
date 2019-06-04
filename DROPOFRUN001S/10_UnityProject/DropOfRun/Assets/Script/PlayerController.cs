using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private Rigidbody rigidbody;
    public bool JumpFlag;   // ジャンプ用フラグ
    private float dush;     // ダッシュ判定
    private new Vector3 CameraForword;
    private new Vector3 CameraRight;
    

    private void FixedUpdate()
    {

        // Spaceキーが押されたときジャンプする
        PlayerJump();

        // Ctrlキーが押されている間ダッシュ
        PlayerDush();
        
        // キー設定
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        
        // カメラの向きを取得
        CameraForword = CameraController.mainCamera.transform.forward;
        CameraRight = CameraController.mainCamera.transform.right;
        
        // プレイヤーの移動
        rigidbody.AddForce(CameraForword * moveVertical * dush + CameraRight * moveHorizontal * dush);
        
    }

    private void PlayerJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !JumpFlag)
        {
            rigidbody.AddForce(Vector3.up * 250);
            JumpFlag = true;
        }
    }

    private void PlayerDush()
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            dush = 1.5f;
        }
        else
        {
            dush = 1.0f;
        }
    }

    void OnCollisionEnter(Collision hit)
    {
        // プレイヤーのジャンプ制限
        if(hit.gameObject.CompareTag("Block"))
        {
            JumpFlag = false;
        }
    }



}
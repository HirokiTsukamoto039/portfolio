using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System.Collections;

public class FollowPlayer : MonoBehaviour {
    //追跡する対象
    public Transform target;
    //カメラとの距離   
    public float dist = 4f;

    //カメラ回転速度
    public float xSpeed = 220.0f;
    public float ySpeed = 100.0f;

    //カメラの初期位置
    private float x = 0.0f;
    private float y = 0.0f;

    //y軸の制限
    public float yMinLimit = -20f;
    public float yMaxLimit = 80f;

    //angle 最小、最大制限
    float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360)
            angle += 360;
        if (angle > 360)
            angle -= 360;
        return Mathf.Clamp(angle, min, max);
    }
    void Start()
    {
        Vector3 angles = transform.eulerAngles;
        x = angles.y;
        y = angles.x;

    }
    void Update()
    {
        if (target)
        {
            //マウススクロールとの距離計算
            dist -= 1 * Input.mouseScrollDelta.y;

            //マウススクロールした場合カメラとの距離のMin＆Max
            if (dist < 0.5)
            {
                dist = 1;
            }
            if (dist >= 9)
            {
                dist = 9;
            }

            //カメラ回転速度計算
            x += Input.GetAxis("Mouse X") * xSpeed * 0.015f;
            y -= Input.GetAxis("Mouse Y") * ySpeed * 0.015f;

            //Angle Setting
            //y軸の MinとMaXをなくすと y軸が 引き続き回転
            //x軸は引き続き回転し、y軸だけ制限
            y = ClampAngle(y, yMinLimit, yMaxLimit);

            //カメラ位置変化計算
            Quaternion rotation = Quaternion.Euler(y, x, 0);
            Vector3 position = rotation * new Vector3(0, 0.0f, -dist) + target.position + new Vector3(0.0f, 0, 0.0f);

            transform.rotation = rotation;
            transform.position = position;
        }

    }
    
}

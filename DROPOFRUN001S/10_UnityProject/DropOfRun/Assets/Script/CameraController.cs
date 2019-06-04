using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public static GameObject mainCamera;
    private GameObject playerObject;
    public static Vector3 mousePosition;
    public float rotateSpeed = 2.0f;

	void Start ()
    {
        mainCamera = Camera.main.gameObject;
        playerObject = GameObject.Find("Player");
		
	}
	
	void Update ()
    {
        rotatoCamera();
		
	}

    private void rotatoCamera()
    {
        Vector3 angle = new Vector3(Input.GetAxis("Mouse X") * rotateSpeed, 
                        Input.GetAxis("Mouse Y") * -rotateSpeed, 0);

        mainCamera.transform.RotateAround(playerObject.transform.position, Vector3.up, angle.x);
        mainCamera.transform.RotateAround(playerObject.transform.position, transform.right, angle.y);
        

    }

}

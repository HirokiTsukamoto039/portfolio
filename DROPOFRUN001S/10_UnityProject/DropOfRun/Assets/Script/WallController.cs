using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour {

    private float width = 13;
    private float length = 0.5f; //Vertical
    private int FloorNumber = GamaLoopManager.InputValueFloor;
    private float FloorSpace = BlockController.FloorSpace;
    private float FloorSpaceHalf = BlockController.FloorSpace / 2;

    // Use this for initialization
    void Start ()
    {
        CreateWall();

    }
	
    private void CreateWall()
    {
        GameObject wallPrefb = (GameObject)Resources.Load("Wall");
        Instantiate(wallPrefb, new Vector3(width, -FloorNumber * FloorSpaceHalf + FloorSpaceHalf + 1, length),
            Quaternion.Euler(0, 0, 0)).transform.localScale += new Vector3(0, FloorNumber * FloorSpace - FloorSpace, 0);
        Instantiate(wallPrefb, new Vector3(length, -FloorNumber * FloorSpaceHalf + FloorSpaceHalf + 1, -width),
            Quaternion.Euler(0, 90, 0)).transform.localScale += new Vector3(0, FloorNumber * FloorSpace - FloorSpace, 0);
        Instantiate(wallPrefb, new Vector3(-width, -FloorNumber * FloorSpaceHalf + FloorSpaceHalf + 1, -length),
            Quaternion.Euler(0, 180, 0)).transform.localScale += new Vector3(0, FloorNumber * FloorSpace - FloorSpace, 0);
        Instantiate(wallPrefb, new Vector3(-length, -FloorNumber * FloorSpaceHalf + FloorSpaceHalf + 1, width),
            Quaternion.Euler(0, 270, 0)).transform.localScale += new Vector3(0, FloorNumber * FloorSpace - FloorSpace, 0);
    }

}

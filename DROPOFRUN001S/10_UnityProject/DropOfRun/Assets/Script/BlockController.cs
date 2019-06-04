using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    
    private float Block_x = 24;
    private int FloorNumber = GamaLoopManager.InputValueFloor;
    private float Block_z = 24;
    public static float FloorSpace = 15;

    [SerializeField] private GameObject stageRoot;


    void Start()
    {
        for(int y = 1;y <= FloorNumber; y++)
        {
            CreateStage(y);
        }
    }

    private void CreateBlock(Vector3 createPosition, Transform parentTransform)
    {
        GameObject BlockObject = (GameObject)Resources.Load("Block");
        GameObject block = Instantiate(BlockObject, createPosition, Quaternion.identity);
        block.transform.SetParent(parentTransform, false);
    }

    private void CreateStage(int floorNumber)
    {
        GameObject stagePrefab = (GameObject)Resources.Load("Stage");
        GameObject stage = Instantiate(stagePrefab, new Vector3(0, 0, 0), Quaternion.identity);
        stage.transform.SetParent(stageRoot.transform, false);

        for (float x = 0; x <= Block_x; x++)
        {
            for (float z = 0; z <= Block_z; z++)
            {
                CreateBlock(new Vector3(x, -floorNumber * FloorSpace + FloorSpace, z), stage.transform);
            }
        }
    }


}

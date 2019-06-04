using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RankingData
{
    public string Name;
    public long Floor;
    public long Time;
    public double AverageTime;

    public RankingData()
    {
        Name = "NoName";
        Floor = 0;
        Time = 0;
        AverageTime = 0.0f;
    }

}

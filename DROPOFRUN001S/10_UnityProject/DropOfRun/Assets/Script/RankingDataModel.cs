using System;
using System.Collections;
using System.Collections.Generic;
using MiniJSON;

public class RankingDataModel
{
    static public List<RankingData> DesirializeFromJson(string sStrJson)
    {
        List<RankingData> ret = new List<RankingData>();
        RankingData tmp = null;

        IList jsonList = (IList)Json.Deserialize(sStrJson);

        foreach (IDictionary jsonOne in jsonList)
        {
            tmp = new RankingData();

            if (jsonOne.Contains("Name"))
            {
                tmp.Name = Convert.ToString(jsonOne["Name"]);
            }
            if (jsonOne.Contains("Floor"))
            {
                tmp.Floor = Convert.ToInt64(jsonOne["Floor"]);
            }
            if (jsonOne.Contains("Time"))
            {
                tmp.Time = Convert.ToInt64(jsonOne["Time"]);
            }
            if (jsonOne.Contains("AverageTime"))
            {
                tmp.AverageTime = Convert.ToDouble(jsonOne["AverageTime"]);
            }
            ret.Add(tmp);
            tmp = null;
        }
        return ret;
    }
}

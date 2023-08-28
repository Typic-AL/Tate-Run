using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveData
{   
    public int meters;
    public int highScore;
    public string map;

    public SaveData(GameManager gm)
    {
        meters = gm.meters;
        highScore = gm.highScore;
        map = gm.map;
    }

}
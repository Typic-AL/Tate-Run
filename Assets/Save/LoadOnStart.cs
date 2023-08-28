using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dreamteck.Forever;

public class LoadOnStart : MonoBehaviour
{
    public LevelGenerator lg;
    public ForeverLevel desert;
    
    // Start is called before the first frame update
    void Start()
    {
        SaveData data = SaveSystem.Load();
        GameManager.Instance.highScore = data.highScore;
        GameManager.Instance.map = data.map;
        if (GameManager.Instance.map == "desert")
        {
            lg.levelCollection.SetValue(desert, 1);
        }
    }

    // Update is called once per frame
    void Update()
    {
            
    }

    private void OnApplicationQuit()
    {
        SaveSystem.Save(GameManager.Instance);
    }
}

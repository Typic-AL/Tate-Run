using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadOnStart : MonoBehaviour
{
    private int counter = 0;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (counter == 0)
        {
            SaveData data = SaveSystem.Load();
            GameManager.Instance.highScore = data.highScore;
            counter = 1;
        }
            
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Pause()
    {
        if (!GameManager.Instance.isPause())
        {
            GameManager.Instance.pause();
        }
        else
        {
            GameManager.Instance.resume();
        }
    }
}

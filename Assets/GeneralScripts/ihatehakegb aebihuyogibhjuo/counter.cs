using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class counter : MonoBehaviour
{
    float multi = 1;
    public TMPro.TextMeshProUGUI counterText;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.Instance.isDead())
            count();
        
        counterText.text = GameManager.Instance.meters.ToString();
    }

    void count() 
    {
        multi = Mathf.Lerp(multi, 2, (float)0.00025);
        if (timer >= .2 / multi)
        {
            GameManager.Instance.meters += 1;
            timer = 0;
        }
        timer += Time.deltaTime;

    }

}

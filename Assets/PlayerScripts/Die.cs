using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{

    private bool dead = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void OnCollisionEnter(Collision col)
    {
        if (!col.gameObject.name.Contains("Terrain"))
        {
            dead = true;
        }
    }

    public bool isDead()
    {
        return dead;
    }
}

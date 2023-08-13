using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityToggle : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;

    private int counter = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(!rb.useGravity) counter++;

        if(counter == 3) rb.useGravity = true;
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Touch touch;
    private float speedModifier;
    public float speed;
    public Camera cam;
    public Light lite;
    private Die die;
    
    void Start()
    {
        speedModifier = 0.003f;
        die = GetComponent<Die>();

    }

    void Update()
    {
        if (!die.isDead())
        {
            if (Input.touchCount > 0)
            {
                touch = Input.GetTouch(0);

                if (touch.phase == TouchPhase.Moved)
                {
                    if(touch.deltaPosition.x * speedModifier > 0 && transform.position.x < 4.3)
                        moveToTouchPos(touch);
                    else if(touch.deltaPosition.x * speedModifier < 0 && transform.position.x > -4.3)
                        moveToTouchPos(touch);
                    
                }
            }

            speed = Mathf.Lerp(speed, 25, .01f * Time.deltaTime);
            print(transform.position.x);
            
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + speed * Time.deltaTime);
            cam.transform.position = new Vector3(cam.transform.position.x, cam.transform.position.y, cam.transform.position.z + speed * Time.deltaTime);
            lite.transform.position = new Vector3(lite.transform.position.x, lite.transform.position.y, lite.transform.position.z + speed * Time.deltaTime);
        }
    }

    private void moveToTouchPos(Touch touch)
    {
        transform.position = new Vector3(
        transform.position.x + touch.deltaPosition.x * speedModifier,
        transform.position.y,
        transform.position.z);
    }
}

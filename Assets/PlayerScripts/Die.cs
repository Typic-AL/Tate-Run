using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Die : MonoBehaviour

{

    private bool dead = false;
    public Button revive;
    public Button restart;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.isDead() && !buttonsNull())
        {
            revive.interactable = true;
            revive.image.color = new Color(revive.image.color.r, revive.image.color.g, revive.image.color.b, 1f);

            restart.interactable = true;
            restart.image.color = new Color(restart.image.color.r, restart.image.color.g, restart.image.color.b, 1f);
        }
        else if(!GameManager.Instance.isDead() && !buttonsNull())
        {
            revive.interactable = false;
            revive.image.color = new Color(revive.image.color.r, revive.image.color.g, revive.image.color.b, 0f);

            restart.interactable = false;
            restart.image.color = new Color(restart.image.color.r, restart.image.color.g, restart.image.color.b, 0f);

        }
    }


    void OnCollisionEnter(Collision col)
    {
        if (!col.gameObject.name.Contains("Terrain") && !col.gameObject.name.Contains("Coin"))

        {
            GameManager.Instance.Die();
            dead = true;
        }
    }

    public bool isDead()
    {
        return dead;
    }

    private bool buttonsNull()
    {
        if (revive == null || restart == null)
            return true;
        else
            return false;
    }


}

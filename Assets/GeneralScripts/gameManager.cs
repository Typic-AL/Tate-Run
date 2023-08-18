using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager


{
    private static GameManager instance;

    private GameManager()
    {
        // initialize your game manager here. Do not reference to GameObjects here (i.e. GameObject.Find etc.)
        // because the game manager will be created before the objects
    }

    public static GameManager Instance
   
    {

        get
        {
            if (instance == null)
            {
                instance = new GameManager();
            }

            return instance;
        }
    }
    private bool dead= false;
    private bool paused = false;

    // Add your game mananger members here
    public void Update()
    {
    }

    public void Die()
    {
        dead = true;
    }
    public void Revive()
    {
        dead = false;

    }
    public bool isDead()
    {
        return dead;
    }
    public void Restart()
    {
        dead = false;
        SceneManager.LoadScene("World");
    }
    public void pause()
    {
        paused = true;

    }
    public void resume()
    {
        paused = false;
    }
    public bool isPause()
    {
        return paused;
    }


}

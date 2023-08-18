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
    public int meters = 0;
    public int highScore = 0;

    // Add your game mananger members here
    public void Update()
    {
    }

   

    #region One Line Functions

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
        updateHighScore(meters);
        meters = 0;
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

    #endregion

    public void Save()
    {
        SaveSystem.Save(Instance);
    }

    public void LoadMeters()
    {
        SaveData data = SaveSystem.Load();

        meters = data.meters;
    }

    private void updateHighScore(int currentMeters)
    {
        SaveData data = SaveSystem.Load();

        if(highScore == 0)
        {
            highScore = currentMeters;
            Save();
        }
        else if(currentMeters > data.highScore)
        {
            highScore = currentMeters;
            Save();
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public Coin coin;
    public AudioSource audioSource;

    private bool started = false;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (started && !audioSource.isPlaying)
            Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name.Contains("Player"))
        {
            GameManager.Instance.incrementCoins();
            audioSource.PlayOneShot(audioSource.clip, 1);
            started = true;
        }
    }
}

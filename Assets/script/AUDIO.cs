using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AUDIO : MonoBehaviour
{
    //private static AudioManager instance;
    public AudioClip trilhaSonora;

    private AudioSource player;
    void Start()
    {
        player = GetComponent<AudioSource>();
        //if(instance == null)
        //{
        //  instance = this;
        DontDestroyOnLoad(gameObject);
        //}
        //else
        //{
        //  Destroy(gameObject);
        //}

        player.clip = trilhaSonora;
        player.Play();
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "")
        {
            player.Stop();
            player.clip = trilhaSonora;
            player.Play();
        }
    }
}

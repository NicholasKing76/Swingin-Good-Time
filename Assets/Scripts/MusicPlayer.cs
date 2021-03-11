using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioSource music;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        music = GetComponent<AudioSource>();
        CheckMusic();
    }

    // Update is called once per frame
    public void PlayMusic()
    {
        if (music.isPlaying) return;
        music.Play();
    }
    public void StopMusic()
    {
        music.Stop();
    }
    public void CheckMusic() 
    {
        if (music.isPlaying)
        {
            Destroy(gameObject);
        }
        else if (music.isPlaying == false)
        {
            PlayMusic();
        }
    }

}

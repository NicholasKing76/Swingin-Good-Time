using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallMusic : MonoBehaviour
{
    public AudioSource deathSound;
    public AudioSource victorySound;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        //deathSound = GetComponent<AudioSource>();
        victorySound = GetComponent<AudioSource>();
    }
    public void PlayVictorySound()
    {
        victorySound.Play();
    }

    public void PlayDeathSound()
    {
        deathSound.Play();
    }
}

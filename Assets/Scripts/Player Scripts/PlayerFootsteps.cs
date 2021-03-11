using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFootsteps : MonoBehaviour
{
    private AudioSource footstep_Sound;

    [SerializeField]
    private AudioClip[] footstep_Clip;

    private CharacterController character_Contoller;

    [HideInInspector]
    public float volume_Min, Volume_Max;

    private float accumulated_Distance;

    [HideInInspector]
    public float step_Distance;

    void Awake()
    {
        footstep_Sound = GetComponent<AudioSource>();

        character_Contoller = GetComponentInParent<CharacterController>();
    }

    void Update()
    {
        CheckForFootSound();
    }

    void CheckForFootSound()
    {
        if (!character_Contoller.isGrounded)
        {//Checks to see if we are in the air
            return; 
        }

        if(character_Contoller.velocity.sqrMagnitude > 0)
        {//Checks to see if the character is moving
             //accumulated distance is the amount of distance before a sound is played
             accumulated_Distance += Time.deltaTime;

             if(accumulated_Distance > step_Distance)
             {
                 footstep_Sound.volume = Random.Range(volume_Min, Volume_Max);
                // footstep_Sound.clip = footstep_Clip[Random.Range(0, footstep_Clip.Length)];
                 footstep_Sound.Play();
                 accumulated_Distance = 0f;
             }
        }
        else
        {
                accumulated_Distance = 0f;//resets accumulated distance
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioOnKeyDown : MonoBehaviour 
{
    public KeyCode Key;
    public AudioSource targetAudioSource;
   
    void Update()
    {
        if (Input.GetKeyDown(Key))
        {
            targetAudioSource.Play();
        }
    }
}

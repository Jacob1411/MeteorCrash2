using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioOnKeyDown : MonoBehaviour 
{
    public KeyCode Key;
    public AudioSource targetAudioSource;
    public floatDelay = 1f;
    public bool acceptingInput = false;

    void Start()
    {
        StartCoroutine(waitThenAcceptInput());
    }

    IEnumerator waitThenAcceptInput()
    {
        yield return new WaitForSeconds(InDelay);
        acceptingInput = true;
    }
   
    void Update()
    {
        if (Input.GetKeyDown(Key))
        {
            targetAudioSource.Play();
            if (OneShot)
            {
                acceptingInput = false;
            }           
        }
    }
}

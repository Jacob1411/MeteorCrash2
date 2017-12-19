using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioOnKeyDown : MonoBehaviour 
{
    public KeyCode Key;
    public AudioSource TargetAudioSource;
    public float InDelay = 1f;
    public bool OneShot = true;

    private bool acceptingInput = false;

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
        if (acceptingInput && Input.GetKeyDown(Key))
        {
            TargetAudioSource.Play();
            if (OneShot)
            {
                acceptingInput = false;
            }           
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class CowSounds : MonoBehaviour, IFocusable
{
    AudioSource source = null;
    AudioClip moo;

    bool play;
    bool toggle;

    void Start()
    {
        //source.clip = Resources.Load<AudioClip>("cow.wav");
        source = gameObject.GetComponent<AudioSource>();
        //source.playOnAwake = false;
        //source.spatialize = true;
        //source.spatialBlend = 1.0f;
        //source.dopplerLevel = 0.0f;
        //source.rolloffMode = AudioRolloffMode.Logarithmic;
        //source.clip = Resources.Load<AudioClip>("cow");
        //source.maxDistance = 20f;
        play = true;
    }

    void Update()
    {
        if (play == true && toggle == true)
        {
            source.Play();
            toggle = false;
        }

        if (play == false && toggle == true)
        {
            source.Stop();
        }

    }


    public void OnFocusEnter()
    {
        //var aani = GetAudioSource(GameObject);
        Debug.Log("I'm looking at a " + gameObject.name);
      //  source.volume = 1f;
        source.Play();  
    }

    public void OnFocusExit()
    {
        Debug.Log("I'm no longer looking at a " + gameObject.name);
        //source.Stop();
    }
}

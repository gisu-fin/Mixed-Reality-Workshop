using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class CowSounds : MonoBehaviour, IFocusable
{

    //AudioSource impactAudioSource = null;

    public AudioClip moo;

    private AudioSource source;

    bool muu;

   // bool gazing = false;

    void Awake()
    {
       /* // Add an AudioSource component and set up some defaults
        impactAudioSource = gameObject.AddComponent<AudioSource>();
        impactAudioSource.playOnAwake = false;
        impactAudioSource.spatialize = true;
        impactAudioSource.spatialBlend = 1.0f;
        impactAudioSource.dopplerLevel = 0.0f;
        impactAudioSource.rolloffMode = AudioRolloffMode.Logarithmic;
        impactAudioSource.maxDistance = 20f;


        // Load the Sphere sounds from the Resources folder
        impactAudioSource.clip = Resources.Load<AudioClip>("cow");
        */

        source.clip = Resources.Load<AudioClip>("cow");
    }


    public void OnFocusEnter()
    {
        Debug.Log("I'm looking at a " + gameObject.name);
        source.clip = moo;
        source.volume = 1f;
        source.Play();
        muu = true;

    }

    public void OnFocusExit()
    {
        Debug.Log("I'm no longer looking at a " + gameObject.name);
        source.Stop();
        muu = false;
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioBox : MonoBehaviour
{
    AudioSource audioSource;

    // make this a singleton
    public static AudioBox instance;

    public void Awake()
    {
        instance = this;
        audioSource = GetComponent<AudioSource>();
        
    }

    public void PlayClip(AudioClip audioClip, float volume)
    {
        if (audioClip == null) return;
        audioSource.PlayOneShot(audioClip, volume);
        
    }

    public void PlayClip(AudioClip audioClip)
    {
        if (audioClip == null) return;
        audioSource.PlayOneShot(audioClip, 1f);
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {
    public static AudioManager Instance;
    private AudioSource activeAudioSource;
    // Use this for initialization
    void Awake()
    {
        if (Instance == null)
            Instance = this;
        Debug.Log("Instance is:" + Instance.name);
    }
    void OnDestroy()
    {
        if (Instance = this)
            Instance = null;
    }
    public void PlayAudio(AudioSource requestedAudioSource)
    {
        Debug.Log("Calling PlayAudio with" + requestedAudioSource.name);
        if(activeAudioSource != null && activeAudioSource.isPlaying)
        {
            Debug.Log("Stopping audio");
            activeAudioSource.Stop();
        }
        Debug.Log("assigning activeAudioSource");
        activeAudioSource = requestedAudioSource;
        Debug.Log("playing activeAudioSource");
        activeAudioSource.Play();
    }
}

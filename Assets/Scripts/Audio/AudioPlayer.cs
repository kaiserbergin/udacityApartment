using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour {
    // Use this for initialization
    public AudioSource audioSource;
    public void PlayAudio()
    {
        AudioManager.Instance.PlayAudio(audioSource);
    }
}

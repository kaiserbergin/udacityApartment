using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScene : MonoBehaviour {

    public AudioSource introClip;
	void Start () {
        if (introClip != null) AudioManager.Instance.PlayAudio(introClip);
	}
}

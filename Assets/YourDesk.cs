using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class YourDesk : MonoBehaviour {

    public AudioSource firstClip;
    public AudioSource secondClip;
    public AudioSource thirdClip;
    private int inspectionCount;

    private void Awake()
    {
        inspectionCount = 0;
    }
    public void PlayDeskAudio()
    {
        switch(inspectionCount)
        {
            case 0:
                if (firstClip != null) AudioManager.Instance.PlayAudio(firstClip);
                break;
            case 1:
                if (secondClip != null) AudioManager.Instance.PlayAudio(secondClip);
                break;
            case 2:
                if (thirdClip != null)
                {
                    AudioManager.Instance.PlayAudio(thirdClip);
                    StartCoroutine(GoToNextSceneAfterFinalClipPlays());
                }

                break;
        }
        inspectionCount++;
    }
    IEnumerator GoToNextSceneAfterFinalClipPlays()
    {
        while(thirdClip.isPlaying)
        {
            Debug.Log("playing");
            yield return null;
        }
        Debug.Log("transition time!");
        SceneManager.LoadScene("MacBurger Apartment");
    }
}

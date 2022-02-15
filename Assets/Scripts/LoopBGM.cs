using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopBGM : MonoBehaviour
{
    public AudioClip introClip;
    public AudioClip loopClip;
    private AudioSource audioSrc;

    private void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        audioSrc.loop = false;
        //audioSrc.clip = loopClip;
        //audioSrc.Play();
        audioSrc.clip = introClip;
        audioSrc.Play();
        StartCoroutine(PlayLoop());
    }

    private IEnumerator PlayLoop()
	{
        //yield return new WaitForSeconds(introClip.length);
        yield return new WaitWhile(() => audioSrc.isPlaying);
        audioSrc.clip = loopClip;
        audioSrc.loop = true;
        audioSrc.Play();
    }
}

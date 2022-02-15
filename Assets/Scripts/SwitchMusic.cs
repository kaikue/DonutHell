using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchMusic : MonoBehaviour
{
    public AudioSource bgm1;
    public AudioSource bgm2;
    [HideInInspector]
    public bool triggered = false;
    private float baseVol;
    private const float FADE_TIME = 1;

    private void Start()
    {
        baseVol = bgm1.volume;
        bgm2.volume = 0;
    }

    public void Switch()
    {
        triggered = true;
        StartCoroutine(CrtSwitch());
    }

    private IEnumerator CrtSwitch()
	{
        for (float t = 0; t < FADE_TIME; t += Time.deltaTime)
		{
            bgm1.volume = Mathf.Lerp(baseVol, 0, t / FADE_TIME);
            bgm2.volume = Mathf.Lerp(0, baseVol, t / FADE_TIME);
            yield return null;
		}
	}
}

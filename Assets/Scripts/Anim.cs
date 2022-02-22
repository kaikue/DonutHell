using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Anim : MonoBehaviour
{
	public Image image;
    public Sprite[] images;
    public float frameTime;

    private int frameIndex;
	private float currentFrameTime;

	private void Update()
	{
		currentFrameTime += Time.deltaTime;
		if (currentFrameTime >= frameTime)
		{
			currentFrameTime = 0;
			frameIndex++;
			if (frameIndex >= images.Length)
			{
				frameIndex = 0;
			}
			image.sprite = images[frameIndex];
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public Transform respawnPoint;
	public SpriteRenderer spriteRenderer;
	public Sprite activeSprite;
    public Sprite inactiveSprite;

	public void Activate()
	{
		spriteRenderer.sprite = activeSprite;
		//TODO sound/particles
	}

	public void Deactivate()
	{
		spriteRenderer.sprite = inactiveSprite;
	}
}

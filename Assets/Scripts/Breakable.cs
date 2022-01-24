using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable : MonoBehaviour
{
    public GameObject breakParticles;
    public bool resetOnDeath = true;

    public void Break()
    {
        Instantiate(breakParticles, transform.position, Quaternion.identity);
        gameObject.SetActive(false);
    }
}

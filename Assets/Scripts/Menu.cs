using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public UnityEvent startEvent;
    public GameObject loadingScreenPrefab;
    public GameObject warning;

	private void Update()
	{
		if (Input.GetButtonDown("Start"))
		{
            startEvent.Invoke();
		}
	}

	public void LoadStart()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(1);
        Instantiate(loadingScreenPrefab);
    }

    public void ShowWarning()
	{
        warning.SetActive(true);
	}

    public void PlayDonutHeaven()
	{
        Application.OpenURL("https://kaikue.itch.io/donut-heaven");
    }

    public void Quit()
    {
        Application.Quit();
    }
}

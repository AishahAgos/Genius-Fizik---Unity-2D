using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour {

	public static bool GameIsPaused = false;
	public GameObject pauseMenuUI; //to control the UI of pause menu

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) 
		{
			if (GameIsPaused) {
				Resume ();
			} 
			else 
			{
				Pause ();
			} 
		}
					
	}

	public void Resume()
	{
		pauseMenuUI.SetActive (false);
		Time.timeScale = 1f;
		GameIsPaused = false;
	}

	void Pause()
	{
		pauseMenuUI.SetActive (true);
		//freeze time
		Time.timeScale = 0f;
		GameIsPaused = true;
	}

	public void LoadMenu()
	{
		//resume the game first before change to menu scene
		Time.timeScale=1;
		SceneManager.LoadScene ("2-GameLevel");

	}

	public void QuitGame ()
	{
		Debug.Log ("Quitting Game");
		Application.Quit();
	}

}

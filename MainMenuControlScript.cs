using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuControlScript : MonoBehaviour {

	public Button level02Button, level03Button;
	public int level1Score = 0, level2Score = 0, level3Score = 0; //added Shakirin
	int levelPassed;

	// Use this for initialization
	void Start () {
		levelPassed = PlayerPrefs.GetInt ("LevelPassed");
		level02Button.interactable = false;
		level03Button.interactable = false;

		//get scores for each level - new added
		if(PlayerPrefs.GetInt("Level1Score") > 0)
			level1Score = PlayerPrefs.GetInt("Level1Score");
		if(PlayerPrefs.GetInt("Level2Score") > 0)
			level2Score = PlayerPrefs.GetInt("Level2Score");
		if(PlayerPrefs.GetInt("Level3Score") > 0)
			level3Score = PlayerPrefs.GetInt("Level3Score");

		//check player's level score to unlock other level - added Shakirin
		if(level1Score >= 10) {
			level02Button.interactable = true;
		}
		if(level2Score >= 10) {
			level03Button.interactable = true;
		}

		/*
		switch (levelPassed) {
		case 1:
			level02Button.interactable = true;
			break;
		case 2:
			level02Button.interactable = true;
			level03Button.interactable = true;
			break;
		}
		*/

	}

	public void levelToLoad (int level)
	{
		SceneManager.LoadScene (level);
	}

	public void resetPlayerPrefs()
	{
		level02Button.interactable = false;
		level03Button.interactable = false;
		PlayerPrefs.DeleteAll ();
	}
}

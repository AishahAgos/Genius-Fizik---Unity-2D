using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BadgesScript : MonoBehaviour {

	public static bool GameIsPaused = false;
	public GameObject ExplainDisplayUI;
	//public GameObject CounterDisplayUI;


	void Start () {
		GameIsPaused = false;
		ExplainDisplayUI.SetActive (false);
	}
		
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.CompareTag("Player"))
		{
			SoundManagerScript.PlaySound ("badgeNew");
			BadgesCounterScript.badgeAmount += 1;
			GameIsPaused = true;
			Destroy (gameObject);
			ExplainDisplayUI.SetActive (true);
			//CounterDisplayUI.SetActive (false);
		}
	}




	//add no of badges into badges counter when player hits the badge
	//destroy the coin after player hit it
	/*
	void OnTriggerEnter2D(Collider2D col)
	{
		BadgesCounterScript.badgeAmount += 1;
		Destroy (gameObject);
	}
	*/
}

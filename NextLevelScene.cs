using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelScene : MonoBehaviour {
	//declare variable : newLevel
	//serializeField enable private variable to be displayed on the Inspector
	[SerializeField] private string newLevel;

	//function
	//enable object to collide with player
	//change into new scene if player collides with the object
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.CompareTag("Player"))
		{
			SceneManager.LoadScene(newLevel);
		}
	}
}

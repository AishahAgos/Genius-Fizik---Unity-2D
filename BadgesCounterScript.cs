using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BadgesCounterScript : MonoBehaviour {
	//declare badges counter as text
	//declare badgeAmount as public to globally share the variable

	Text text;
	public static int badgeAmount;

	//function
	//initialization
	void Start()
	{
		//retrieve the content from Text and assign it to the text variable
		text = GetComponent<Text>();
	}

	void Update()
	{
		//convert the datatype of text from int to string
		text.text = badgeAmount.ToString();
	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class lvl2Script : MonoBehaviour
{

	public Text thankYouText;
	public Animation treasureAnimation;
	// Use this for initialization
	void Start ()
	{
		if (fishScript.lvl2Bool == true)
		{
			thankYouText.text = "You've leveled up since you've been here last!" +
				"Check your treasure chest to see what you've unlocked!";
			treasureAnimation.Play ();

		}
	}
}

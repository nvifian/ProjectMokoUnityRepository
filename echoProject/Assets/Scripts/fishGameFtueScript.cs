using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class fishGameFtueScript : MonoBehaviour
{
	public static bool fishFtueBool;
	public Text textString;
	public Animation logoAnimation;
	public  int nextInt;

	public void Start ()
	{
		fishFtueBool = true;
		nextInt = 1;
	}

	public void NextButtonFunction()
	{
		if (nextInt == 2)
		{
			SceneManager.LoadScene ("fishGameSceneTest");
		}
		if (nextInt == 1)
		{
			StartCoroutine (lstButton ());
			logoAnimation.Play ();
		}
	}

	IEnumerator lstButton()
	{
		yield return new WaitForSeconds (3f);
		textString.text = "Swipe the fish up with the most accurate answer to feed Moko!";
		nextInt=2;
	}
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ftueScript : MonoBehaviour
{

	public GameObject ftueText1;
	public GameObject ftueText2;
	public GameObject ftueObject;
	public Text nextButtonText;
	public static int buttonInt;

	void Start ()
	{
		if (buttonInt > 0)
		{
			Destroy (ftueObject);
		}
		if (buttonInt == 0)
		{
			ftueText1.SetActive (true);
			buttonInt = 1;
		}
	}

	public void NextButtonFunction()
	{
		if (buttonInt == 2)
		{
			ftueText2.SetActive (false);
			nextButtonText.text = "START!";
			SceneManager.LoadScene ("mainScene");
		}
		if (buttonInt == 1)
		{
			ftueText1.SetActive (false);
			ftueText2.SetActive (true);
			buttonInt=2;

		}
	}
}

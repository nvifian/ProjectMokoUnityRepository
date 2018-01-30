using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class avatarMenuScript : MonoBehaviour
{
	public static bool beachBallBool;
	public bool hoopBool;
	public bool basketBallBool;
	public static bool lvl2Bool;
	public static bool lvl3Bool;
	public static bool lvl4Bool;
	public static bool lvl5Bool;
	public Transform beachBallTransform;
	public GameObject beachBallButtonObject;
	public GameObject hoopButtonObject;
	public GameObject basketBallButtonObject;
	public GameObject beachBallObject;
	public GameObject hoopObject;
	public GameObject basketBallObject;
	public GameObject leftArrowObject;
	public GameObject rightArrowObject;
	public RawImage beachBallButton;
	public RawImage beachBallRawImage; //disable and enable
	public Text beachBallText;
	public Text hoopText;
	public Text basketballText;
	public Text mokoText;
	public Animation dolphinTextFadeAnimation;
	public float countdownFloat;
	public int inventoryInt;

	public void Start ()
	{
		inventoryInt = 1;
		beachBallBool = true;
	}

	public void beachBallFunction()
	{
		countdownFloat = 10;
		if(beachBallBool == false)
		{
			Invoke ("BallEnableFunction",.1f);

		}
		if(beachBallBool == true)
		{
			Invoke ("BallDisableFunction",.1f);
		}
	}

	public void BallEnableFunction()
	{
		beachBallRawImage.enabled = true;
		beachBallObject.transform.position = beachBallTransform.position;
		beachBallButton.color = new Color (0,0,0,.5f);
		beachBallText.text = "tap to return ball";
		beachBallBool = true;
	}

	public void BallDisableFunction()
	{
		countdownFloat = 10;
		beachBallRawImage.enabled = false;
		beachBallText.text = "beach ball";
		beachBallButton.color = new Color (1,1,1,1);
		beachBallBool = false;
	}

	public void RightButtonFunction()
	{
		inventoryInt++;
	}

	public void LeftButtonFunction()
	{
		inventoryInt--;
	}

	public void Update()
	{
		Debug.Log (beachBallBool);
		Debug.Log (inventoryInt);
		Debug.Log (countdownFloat);
		if (beachBallBool == false)
		{
			countdownFloat -= Time.deltaTime;
		}
		if (countdownFloat < 0)
		{
			dolphinTextFadeAnimation.Play ();
			mokoText.text = "I want to play with the beach ball!";
		}

		if (countdownFloat > 0)
		{
			mokoText.text = "  ";
		}
		if (inventoryInt == 1)
		{
			beachBallButtonObject.SetActive (true);
			hoopButtonObject.SetActive (false);
			basketBallButtonObject.SetActive (false);
			leftArrowObject.SetActive (false);
			rightArrowObject.SetActive (true);
		}
		if (inventoryInt == 2)
		{
			beachBallButtonObject.SetActive (false);
			hoopButtonObject.SetActive (true);
			basketBallButtonObject.SetActive (false);
			leftArrowObject.SetActive (true);
		}
		if (inventoryInt == 3)
		{
			beachBallButtonObject.SetActive (false);
			hoopButtonObject.SetActive (false);
			basketBallButtonObject.SetActive (true);
			rightArrowObject.SetActive (false);
		}
	}
}
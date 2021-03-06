using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class buttonScript : MonoBehaviour
{
	public Animation menuAnimation;
	public AnimationClip menuAnimationOpen;
	public AnimationClip menuAnimationClose;
	public Animation treasureAnimation;
	public Transform treasureMenuCloseTransform;
	public Transform treasureMenuTransform;
	public Text lvl5Text;
	public AudioSource buttonAudio;
	public bool treasureAnimationBool;
	public static GameObject lvl5Object;
	public static bool treasureMenuBool;
	public static bool ftueBool;

	public void treasureButton ()
	{
		treasureAnimationBool = false;
		menuAnimation.Play("menuAnimationOpen");
		treasureMenuBool = true;
	}

	public void TreasureMenuClose ()
	{
		if (treasureMenuBool == true)
		{
			menuAnimation.Play ("menuAnimationClose");
			treasureMenuBool = false;
		}
	}

	public void level5Unlockable()
	{
		StartCoroutine (Level5Routine ());
	}

	public void gameButton ()
	{
		SceneManager.LoadScene ("gameMenuScene");
		treasureAnimation.Stop ();
	}

	public void mapButton ()
	{
		if (mapScript.mapBool == true)
		{
			SceneManager.LoadScene ("mapScene");
		}
		if (mapScript.mapBool == false)
		{
			SceneManager.LoadScene ("mapFtueScene");
		}
	}

	public void homeButton ()
	{
		SceneManager.LoadScene ("mainScene");
	}

	public void logButton ()
	{
		SceneManager.LoadScene ("logScene");
	}

	public void fishGameButton ()
	{
		SceneManager.LoadScene ("fishGameSceneTest");
	}

	public void ticketButton()
	{
		SceneManager.LoadScene ("lvl52Scene");
	}

	public void fishFtueButton ()
	{
		if (fishGameFtueScript.fishFtueBool == false)
		{
			StartCoroutine (FtueCoroutine ());
		}
		if (fishGameFtueScript.fishFtueBool == true)
		{
			StartCoroutine (FishGameCoroutine ());
		}
	}

	IEnumerator FtueCoroutine ()
	{
		buttonAudio.Play ();
		yield return new WaitForSeconds (.25f);
		SceneManager.LoadScene ("fishGameFtueScene");
	}

	IEnumerator FishGameCoroutine()
	{
		buttonAudio.Play ();
		yield return new WaitForSeconds (.25f);
		SceneManager.LoadScene ("fishGameSceneTest");
	}

	IEnumerator Level5Routine()
	{
		if (fishScript.lvl5Bool == true)
		{
			yield return new WaitForSeconds (.25f);
			SceneManager.LoadScene ("lvl5Scene");
		}

		if (fishScript.lvl5Bool == false)
		{
			lvl5Text.text = "Unlock at level 5";
			yield return new WaitForSeconds (2.5f);
			lvl5Text.text = " ";
		}
	}
}
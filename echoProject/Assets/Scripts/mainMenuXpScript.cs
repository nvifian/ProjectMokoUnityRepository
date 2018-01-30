using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class mainMenuXpScript : MonoBehaviour
{
	public static int lvlInt;
	public static bool lvl1Bool;
	public static bool lvl2Bool;
	public static bool lvl3Bool;
	public static bool lvl4Bool;
	public static bool lvl5Bool;
	public static int questionInt;
	public static GameObject lvl5Object;
	public GameObject xp1Object;
	public GameObject xp2Object;
	public GameObject xp3Object;
	public GameObject xp4Object;
	public GameObject xp5Object;
	public GameObject xp6Object;
	public GameObject xp7Object;
	public GameObject xp8Object;
	public GameObject xp9Object;
	public GameObject xp10Object;
	public GameObject xp11Object;
	public GameObject xp12Object;
	public GameObject xp13Object;
	public GameObject xp14Object;
	public GameObject xp15Object;
	public GameObject xp16Object;
	public GameObject xp17Object;
	public GameObject xp18Object;
	public GameObject xp19Object;
	public GameObject xp20Object;
	public Text lvlText; //use this to display level, change to 'level up!' when level change
	public Text xpText;

	public void Update ()
	{
		if (fishScript.lvlInt == 1)
		{
			lvlText.text = "Level 1";
		}
		if (fishScript.lvlInt == 2)
		{
			lvlText.text = "Level 2";
		}
		if (fishScript.lvlInt == 3)
		{
			lvlText.text = "Level 3";
		}
		if (fishScript.lvlInt == 4)
		{
			lvlText.text = "Level 4";
		}
		if (fishScript.lvlInt == 5)
		{
			lvlText.text = "Level 5";
			buttonScript.lvl5Object.SetActive (true);
		}

		if (questionInt == 1)
		{
			xpText.text = questionInt + "  /  9";
			xp1Object.SetActive (true);
		}
		if (questionInt == 2)
		{
			xpText.text = questionInt + "  /  9";
			xp2Object.SetActive (true);
		}
		if (questionInt == 3)
		{
			xpText.text = questionInt + "  /  9";
			xp3Object.SetActive (true);
		}
		if (questionInt == 4)
		{
			xpText.text = questionInt + "  /  9";
			xp4Object.SetActive (true);
		}
		if (questionInt == 5)
		{
			xpText.text = questionInt + "  /  9";
			xp5Object.SetActive (true);
		}
		if (questionInt == 6)
		{
			xpText.text = questionInt + "  /  9";
			xp6Object.SetActive (true);
		}
		if (questionInt == 7)
		{
			xpText.text = questionInt + "  /  9";
			xp7Object.SetActive (true);
		}
		if (questionInt == 8)
		{
			xpText.text = questionInt + "  /  9";
			xp8Object.SetActive (true);
		}
		if (questionInt == 9)
		{
			xpText.text = questionInt-9 + "  /  11";
			xp10Object.SetActive (true);
			xp1Object.SetActive (false);
			xp2Object.SetActive (false);
			xp3Object.SetActive (false);
			xp4Object.SetActive (false);
			xp5Object.SetActive (false);
			xp6Object.SetActive (false);
			xp7Object.SetActive (false);
			xp8Object.SetActive (false);
			xp9Object.SetActive (false);
		}
		//LVL 2 // CHANGE questionGroupText string
		if (questionInt == 10)
		{
			lvlInt = 2;
			xpText.text = questionInt-9 + "  /  11";
			xp10Object.SetActive (true);
		}
		if (questionInt == 11)
		{
			xpText.text = questionInt-9 + "  /  11";
			xp11Object.SetActive (true);
		}
		if (questionInt == 12)
		{
			xpText.text = questionInt-9 + "  /  11";
			xp12Object.SetActive (true);
		}
		if (questionInt == 13)
		{
			xpText.text = questionInt-9 + "  /  11";
			xp13Object.SetActive (true);
		}
		if (questionInt == 14)
		{
			xpText.text = questionInt-9 + "  /  11";
			xp14Object.SetActive (true);
		}
		if (questionInt == 15)
		{
			xpText.text = questionInt-9 + "  /  11";
			xp15Object.SetActive (true);
		}
		if (questionInt == 16)
		{
			xpText.text = questionInt-9 + "  /  11";
			xp16Object.SetActive (true);
		}
		if (questionInt == 17)
		{
			xpText.text = questionInt-9 + "  /  11";
			xp17Object.SetActive (true);
		}
		if (questionInt == 18)
		{
			xpText.text = questionInt-9 + "  /  11";
			xp18Object.SetActive (true);
		}
		if (questionInt ==19)
		{
			xpText.text = questionInt-9 + "  /  11";
			xp19Object.SetActive (true);
		}
		if (questionInt == 20)
		{
			xpText.text = questionInt-9 + "  /  11";
			xp20Object.SetActive (true);
			xpText.text = "NEW ITEM!";
		}
		//LVL3
		if (questionInt == 21)
		{
			xpText.text = questionInt-20 + "  /  14";
		}
		if (questionInt == 22)
		{
			xpText.text = questionInt-20 + "  /  14";
		}

	}
}
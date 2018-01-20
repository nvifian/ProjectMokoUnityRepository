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
	public GameObject xp1Object;
	public GameObject xp2Object;
	public GameObject xp3Object;
	public GameObject xp4Object;
	public GameObject xp5Object;
	public GameObject xp6Object;
	public GameObject xp7Object;
	public GameObject xp8Object;
	public GameObject xp9Object;
	public Text lvlText; //use this to display level, change to 'level up!' when level change
	public Text xpText;

	void Start ()
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
		}

		if (questionInt == 1)
		{
			lvlInt = 1;
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
			lvl1Bool = false;
			Invoke ("NewLevelRoutine",0f);
			lvl2Bool = true;
		}
		//LVL 2 // CHANGE questionGroupText string
		if (questionInt == 10)
		{
			lvlInt = 2;
			xpText.text =  " 0 /  11";
			xp1Object.SetActive (true);
		}
		if (questionInt == 11)
		{
			xpText.text = questionInt-9 + "  /  11";
		}
		if (questionInt == 12)
		{
			xpText.text = questionInt-9 + "  /  11";
		}
		if (questionInt == 13)
		{
			xpText.text = questionInt-9 + "  /  11";
		}
		if (questionInt == 14)
		{
			xpText.text = questionInt-9 + "  /  11";
		}
		if (questionInt == 15)
		{
			xpText.text = questionInt-9 + "  /  11";
		}
		if (questionInt == 16)
		{
			xpText.text = questionInt-9 + "  /  11";
		}
		if (questionInt == 17)
		{
			xpText.text = questionInt-9 + "  /  11";
		}
		if (questionInt == 18)
		{
			xpText.text = questionInt-9 + "  /  11";
		}
		if (questionInt ==19)
		{
			xpText.text = questionInt-9 + "  /  11";
		}
		if (questionInt == 20)
		{
			xpText.text = questionInt-9 + "  /  11";
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
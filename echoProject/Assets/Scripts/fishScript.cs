using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class fishScript : MonoBehaviour
{
	public static int questionInt;
	public static int lvlInt;
	public static int fish1Int;
	public static int fish2Int;
	public static int fish3Int;
	public static int fish4Int;
	public static int lvl2Int1;
	public static int lvl2Int2;
	public static int lvl2Int3;
	public static int lvl2Int4;
	public static int lvl2Int5;
	public static int lvl2Int6;
	public static int lvl2Int7;
	public static bool lvl1Bool;
	public static bool lvl2Bool;
	public static bool lvl3Bool;
	public static bool lvl4Bool;
	public static bool lvl5Bool;
	public bool newLevelBool;
	public bool fish1Bool;
	public bool fish2Bool;
	public bool fish3Bool;
	public bool fish4Bool;
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
	public GameObject xp21Object;
	public GameObject xp22Object;
	public GameObject xp23Object;
	public GameObject xp24Object;
	public GameObject xp25Object;
	public GameObject xp26Object;
	public GameObject xp27Object;
	public GameObject xp28Object;
	public GameObject xp29Object;
	public GameObject xp30Object;
	public GameObject xp31Object;
	public GameObject xp32Object;
	public GameObject xp33Object;
	public GameObject xp34Object;
	public GameObject xp35Object;
	public GameObject xp36Object;
	public GameObject xp37Object;
	public GameObject xp38Object;
	public GameObject xp39Object;
	public GameObject xp40Object;
	public GameObject xp41Object;
	public GameObject xp42Object;
	public GameObject xp43Object;
	public GameObject xp44Object;
	public GameObject xp45Object;
	public GameObject xp46Object;
	public GameObject xp47Object;
	public GameObject xp48Object;
	public GameObject xp49Object;
	public GameObject xp50Object;
	public GameObject fish1;
	public GameObject fish2;
	public GameObject fish3;
	public GameObject fish4;
	public GameObject dolphinObject;
	public Text questionSetText;
	public Text questionText;
	public Text game2Question1Text;
	public Text game2Question2Text;
	public Text xpText;
	public Text fish1Text;
	public Text fish2Text;
	public Text fish3Text;
	public Text fish4Text;
	public Text lvlText; //use this to display level, change to 'level up!' when level change
	//public Text xpText;
	public Vector2 fishVector;
	public AudioSource levelUpAudio;
	public AudioSource dolphinCorrect;
	public Animation newLvlAnimation;
	public Animation dolphinAnimation;
	public Vector2 boatVector = new Vector2 (0,350);
	public Vector2 fish1Vector = new Vector2 (-200, -100);
	public Vector2 fish2Vector = new Vector2 (-50, -100);
	public Vector2 fish3Vector = new Vector2 (50, -200);
	public Vector2 fish4Vector = new Vector2 (-60, -300);
	public Vector2 dolphinResetVector = new Vector2 (465, 275);
	public Transform fishTransform;

	void Start ()
	{
		if (lvlInt == 1)
		{
			lvlText.text = "Level 1";
		}
		fish1Bool = false;
		fish2Bool = false;
		fish3Bool = false;
		fish4Bool = false;
	}

	public void Game2 ()
	{
		Invoke ("Game2Routine", 1.25f);
	}

	public void Fish1 ()
	{
		fish1Bool = true;
		Invoke ("DolphinRoutine", 1.25f);
		dolphinAnimation.Play ();
	}

	public void Fish2 ()
	{
		fish2Bool = true;
		dolphinAnimation.Play ();
		Invoke ("DolphinRoutine", 1.25f);
	}

	public void Fish3 ()
	{
		fish3Bool = true;
		dolphinAnimation.Play ();
		Invoke ("DolphinRoutine", 1.25f);
	}

	public void Fish4 ()
	{
		fish4Bool = true;
		dolphinAnimation.Play ();
		Invoke ("DolphinRoutine", 1.25f);
	}

	public void Game2Routine()
	{
		questionInt++;
		StopAllCoroutines ();
	}

	public void DolphinRoutine()
	{
		fish1Bool = false;
		fish2Bool = false;
		fish3Bool = false;
		fish4Bool = false;
		fish1.transform.position = fish1Vector;
		fish2.transform.position = fish2Vector;
		fish3.transform.position = fish3Vector;
		fish4.transform.position = fish4Vector;
		fish1.transform.rotation = xp1Object.transform.rotation;
		fish2.transform.rotation = xp1Object.transform.rotation;
		fish3.transform.rotation = xp1Object.transform.rotation;
		fish4.transform.rotation = xp1Object.transform.rotation;
		dolphinObject.transform.position = dolphinResetVector;
		dolphinCorrect.Play ();
		questionInt++;
		StopAllCoroutines ();
	}

	public void LevelRoutine()
	{
		if (questionInt > 1 && questionInt <10)
		{
			lvlText.text = "1";
		}
		if (questionInt >11 && questionInt <18)
		{
			lvlText.text = "2";
		}
	}

	IEnumerator NewLevelRoutine()
	{
		if (newLevelBool == true)
		{
			xp9Object.SetActive (true);
			xpText.text = "NEW LEVEL!";
			//levelUpAudio.Play (1);
			newLvlAnimation.Play ();
			xp1Object.SetActive (false);
			xp2Object.SetActive (false);
			xp3Object.SetActive (false);
			xp4Object.SetActive (false);
			xp5Object.SetActive (false);
			xp6Object.SetActive (false);
			xp7Object.SetActive (false);
			xp8Object.SetActive (false);
			xp8Object.SetActive (false);
			xp9Object.SetActive (false);
			xp10Object.SetActive (false);
			xp11Object.SetActive (false);
			xp12Object.SetActive (false);
			xp13Object.SetActive (false);
			xp14Object.SetActive (false);
			xp15Object.SetActive (false);
			xp16Object.SetActive (false);
			xp17Object.SetActive (false);
			xp18Object.SetActive (false);
			xp19Object.SetActive (false);
			xp20Object.SetActive (false);
			xp21Object.SetActive (false);
			xp22Object.SetActive (false);
			xp23Object.SetActive (false);
			xp24Object.SetActive (false);
			xp25Object.SetActive (false);
			xp26Object.SetActive (false);
			xp27Object.SetActive (false);
			xp28Object.SetActive (false);
			xp29Object.SetActive (false);
			xp30Object.SetActive (false);
			xp31Object.SetActive (false);
			xp32Object.SetActive (false);
			xp33Object.SetActive (false);
			xp34Object.SetActive (false);
			xp35Object.SetActive (false);
			xp36Object.SetActive (false);
			xp37Object.SetActive (false);
			xp38Object.SetActive (false);
			xp39Object.SetActive (false);
			xp40Object.SetActive (false);
			xp41Object.SetActive (false);
			xp42Object.SetActive (false);
			xp43Object.SetActive (false);
			xp44Object.SetActive (false);
			xp45Object.SetActive (false);
			xp46Object.SetActive (false);
			xp47Object.SetActive (false);
			xp48Object.SetActive (false);
			xp49Object.SetActive (false);
			xp50Object.SetActive (false);
			newLevelBool = false;
			yield return new WaitForSeconds (1);
			StopAllCoroutines ();
		}
	}

	void Update()
	{
		Debug.Log (questionInt);
		if (fish1Bool == true)
		{
			StartCoroutine(fish1Coroutine(new Vector2 (0,350)));
		}
		if (fish2Bool == true)
		{
			StartCoroutine(fish2Coroutine(new Vector2 (0,350)));
		}
		if (fish3Bool == true)
		{
			StartCoroutine(fish3Coroutine(new Vector2 (0,350)));
		}
		if (fish4Bool == true)
		{
			StartCoroutine(fish4Coroutine(new Vector2 (0,350)));
		}
		if (questionInt == 1)
		{
			lvlInt = 1;
			xpText.text = questionInt + "  /  9";
			xp1Object.SetActive (true);
			questionText.text = "Little interest or pleasure in doing things";
		}
		if (questionInt == 2)
		{
			xpText.text = questionInt + "  /  9";
			xp2Object.SetActive (true);
			questionText.text = "Feeling down, depressed or hopeless";
		}
		if (questionInt == 3)
		{
			xpText.text = questionInt + "  /  9";
			xp3Object.SetActive (true);
			questionText.text = "Trouble falling asleep, or sleeping too much";
		}
		if (questionInt == 4)
		{
			xpText.text = questionInt + "  /  9";
			xp4Object.SetActive (true);
			questionText.text = "Feeling tired or having little energy";
		}
		if (questionInt == 5)
		{
			xpText.text = questionInt + "  /  9";
			xp5Object.SetActive (true);
			questionText.text = "Poor appetite or overeating";
		}
		if (questionInt == 6)
		{
			xpText.text = questionInt + "  /  9";
			xp6Object.SetActive (true);
			questionText.text = "Feeling bad about yourself, or that you are a failure or let yourself or family down.";
		}
		if (questionInt == 7)
		{
			xpText.text = questionInt + "  /  9";
			xp7Object.SetActive (true);
			questionText.text = "Trouble concentrating on things, such as reading the newspaper or watching television.";
		}
		if (questionInt == 8)
		{
			xpText.text = questionInt + "  /  9";
			xp8Object.SetActive (true);
			questionText.text = "Moving or speaking so slowly that people hav noticed / being so fidgety that you have been moving a lot more than usual. ";
		}
		if (questionInt == 9)
		{
			newLevelBool = true;
			StartCoroutine (NewLevelRoutine ());
			newLevelBool = true;
			lvl2Bool = true;
			questionText.text = "Thoughts that you would be better off dead or of hurting yourself in some way";
		}
		//LVL 2 // CHANGE questionGroupText string
		if (questionInt == 10)
		{
			lvlInt =2;
			lvlText.text = "Level 2";
			lvl2Bool = true;
			xpText.text = xpText.text = questionInt-9 + "  /  11";
			xp1Object.SetActive (true);
			newLevelBool = false;
			questionText.text = "Feeling nervous, anxious or on the edge.";
		}
		if (questionInt == 11)
		{
			xpText.text = questionInt-9 + "  /  11";
			xp11Object.SetActive (true);
			questionText.text = "Worrying too much about different things.";
		}
		if (questionInt == 12)
		{
			xpText.text = questionInt-9 + "  /  11";
			xp12Object.SetActive (true);
			questionText.text = "Trouble relaxing.";
		}
		if (questionInt == 13)
		{
			xpText.text = questionInt-9 + "  /  11";
			xp13Object.SetActive (true);
			questionText.text = "Being so restless that it is hard to sit still.";
		}
		if (questionInt == 14)
		{
			xpText.text = questionInt-9 + "  /  11";
			xp14Object.SetActive (true);
			questionText.text = "Beecoming easily annoyed or irritable.";
		}
		if (questionInt == 15)
		{
			xpText.text = questionInt-9 + "  /  11";
			xp15Object.SetActive (true);
			questionText.text = "Feeling afraid as if something awful might happen.";
		}
		if (questionInt == 16)
		{
			xpText.text = questionInt-9 + "  /  11";
			xp16Object.SetActive (true);
			questionText.text = "Little interest or pleasure in doing things";
		}
		if (questionInt == 17)
		{
			xpText.text = questionInt-9 + "  /  11";
			xp17Object.SetActive (true);
			questionText.text = "Feeling down, depressed or hopeless.";
		}
		if (questionInt == 18)
		{
			xpText.text = questionInt-9 + "  /  11";
			xp18Object.SetActive (true);
			questionText.text = "Feeling nervous, anxious, or on the edge.";
		}
		if (questionInt ==19)
		{
			xpText.text = questionInt-9 + "  /  11";
			xp19Object.SetActive (true);
			questionText.text = "Not being able to stop or control worrying.";
		}
		if (questionInt == 20)
		{
			xpText.text = questionInt-9 + "  /  11";
			xp20Object.SetActive (true);
			newLevelBool = true;
			StartCoroutine (NewLevelRoutine ());
			newLevelBool = true;
			xpText.text = "NEW LEVEL!";
			questionText.text = "Not being able to stop or control worrying.";
		}
		//LVL3
		if (questionInt == 21)
		{
			lvlInt =3;
			lvlText.text = "Level 3";
			newLevelBool = false;
			lvl3Bool = true;
			xp21Object.SetActive (true);
			xpText.text = questionInt-20 + "  /  14";
			questionText.text = "I've been feeling optimistic about the future.";
		}
		if (questionInt == 22)
		{
			xpText.text = questionInt-20 + "  /  14";
			xp22Object.SetActive (true);
			questionText.text = "I've been feeling useful.";
		}
		if (questionInt == 23)
		{
			xpText.text = questionInt-20 + "  /  14";
			xp23Object.SetActive (true);
			questionText.text = "I've been feeling relaxed.";
		}
		if (questionInt == 24)
		{
			xpText.text = questionInt-20 + "  /  14";
			xp24Object.SetActive (true);
			questionText.text = "I've been feeling interested in other people.";
		}
		if (questionInt == 25)
		{
			xpText.text = questionInt-20 + "  /  14";
			xp25Object.SetActive (true);
			questionText.text = "I've had energy to spare.";
		}
		if (questionInt == 26)
		{
			xpText.text = questionInt-20 + "  /  14";
			xp26Object.SetActive (true);
			questionText.text = "I've been dealing with problems well.";
		}
		if (questionInt == 27)
		{
			lvlInt =3;
			xpText.text = questionInt-20 + "  /  14";
			xp27Object.SetActive (true);
			questionText.text = "I've been thinking clearly.";
		}
		if (questionInt == 28)
		{
			xp28Object.SetActive (true);
			xpText.text = questionInt-20 + "  /  14";
			questionText.text = "I've been feeling good about myself.";
		}
		if (questionInt == 29)
		{
			xp29Object.SetActive (true);
			xpText.text = questionInt-20 + "  /  14";
				questionText.text = "I've been feeling close to other people.";
		}
		if (questionInt == 30)
		{
			xp30Object.SetActive (true);
			xpText.text = questionInt-20 + "  /  14";
			questionText.text = "I've been feeling confident.";
		}
		if (questionInt == 31)
		{
			xp31Object.SetActive (true);
			xpText.text = questionInt-20 + "  /  14";
				questionText.text = "I've been able to make up my own mind about things.";
		}
		if (questionInt == 32)
		{
			xp32Object.SetActive (true);
			xpText.text = questionInt-20 + "  /  14";
				questionText.text = "I've been feeling loved.";
		}
		if (questionInt == 33)
		{
			xp33Object.SetActive (true);
			xpText.text = questionInt-20 + "  /  14";
				questionText.text = "I've been interested in new things.";
		}
		if (questionInt == 34)
		{
			xp34Object.SetActive (true);
			newLevelBool = true;
			StartCoroutine (NewLevelRoutine ());
			newLevelBool = true;
			SceneManager.LoadScene ("Game2Scene");
			xpText.text = "NEW LEVEL!";
			questionText.text = "I've been feeling cheerful.";
		}
		//LVL4
		if (questionInt == 35)
		{
			lvlText.text = "Level 4";
			lvlInt =4;
			newLevelBool = false;
			lvl4Bool = true;
			xp35Object.SetActive (true);
			xpText.text = questionInt-34 + "  /  16";
			game2Question1Text.text = "Leave people to their own devices";
			game2Question2Text.text = "help people";
		}
		if (questionInt == 36)
		{
			xp36Object.SetActive (true);
			xpText.text = questionInt-34 + "  /  16";
			game2Question1Text.text = "don't care about success";
			game2Question2Text.text = "need to be successful";
		}
		if (questionInt == 37)
		{
			xp37Object.SetActive (true);
			xpText.text = questionInt-34 + "  /  16";
			game2Question1Text.text = "relying on others";
			game2Question2Text.text = "independent";
		}
		if (questionInt == 38)
		{
			xp38Object.SetActive (true);
			xpText.text = questionInt-34 + "  /  16";
			game2Question1Text.text = "don't care about success";
			game2Question2Text.text = "need to be successful";
		}
		if (questionInt == 39)
		{
			xp39Object.SetActive (true);
			xpText.text = questionInt-34 + "  /  16";
			game2Question1Text.text = "even tempered";
			game2Question2Text.text = "tempermental";
		}
		if (questionInt == 40)
		{
			xp40Object.SetActive (true);
			xpText.text = questionInt-34 + "  /  16";
			game2Question1Text.text = "rule breaking";
			game2Question2Text.text = "rule abiding";
		}
		if (questionInt == 41)
		{
			xp41Object.SetActive (true);
			xpText.text = questionInt-34 + "  /  16";
			game2Question1Text.text = "relaxed";
			game2Question2Text.text = "anxious";
		}
		if (questionInt == 42)
		{
			xp42Object.SetActive (true);
			xpText.text = questionInt-34 + "  /  16";
			game2Question1Text.text = "aloof";
			game2Question2Text.text = "warm";
		}
		if (questionInt == 43)
		{
			xp43Object.SetActive (true);
			xpText.text = questionInt-34 + "  /  16";
			game2Question1Text.text = "avoiding conflicts";
			game2Question2Text.text = "confrontational";
		}
		if (questionInt == 44)
		{
			xp44Object.SetActive (true);
			xpText.text = questionInt-34 + "  /  16";
			game2Question1Text.text = "teams and groups preferred";
			game2Question2Text.text = "individualistic";
		}
		if (questionInt == 45)
		{
			xp45Object.SetActive (true);
			xpText.text = questionInt-34 + "  /  16";
			game2Question1Text.text = "dispassionate";
			game2Question2Text.text = "passionate";
		}
		if (questionInt == 46)
		{
			xp46Object.SetActive (true);
			xpText.text = questionInt-34 + "  /  16";
			game2Question1Text.text = "pragmatic";
			game2Question2Text.text = "idealistic";
		}
		if (questionInt == 47)
		{
			xp47Object.SetActive (true);
			xpText.text = questionInt-34 + "  /  16";
			game2Question1Text.text = "reluctant";
			game2Question2Text.text = "enthusiastic";
		}
		if (questionInt == 48)
		{
			xp48Object.SetActive (true);
			xpText.text = questionInt-34 + "  /  16";
			game2Question1Text.text = "tolerant";
			game2Question2Text.text = "critical";
		}
		if (questionInt == 49)
		{
			xp49Object.SetActive (true);
			xpText.text = questionInt-34 + "  /  16";
			game2Question1Text.text = "ordinary";
			game2Question2Text.text = "different";
		}
		if (questionInt == 50)
		{
			lvl5Bool = true;
			xp50Object.SetActive (true);
			xpText.text = "GO TO MAIN";
			newLevelBool = true;
			StartCoroutine (NewLevelRoutine ());
			newLevelBool = true;
			game2Question1Text.text = "politically indifferent";
			game2Question2Text.text = "politically opinionated";
		}
		if (questionInt == 51)
		{
			xpText.text = questionInt-34 + "  /  16";
			newLevelBool = true;
			lvl5Bool = true;
			StartCoroutine (NewLevelRoutine ());
			newLevelBool = true;
			game2Question1Text.text = " ";
			game2Question2Text.text = " ";
		}
		//LVL5
		//questionSetText.text = "Select the option that makes the most sense to you. If you don't know, select "No".";
		//change game to something with sliding scale type situation (radio)


	}


	IEnumerator fish1Coroutine(Vector2 fishVector)
	{
		fish1.transform.Rotate(Time.deltaTime,0,5);

		while (Vector3.Distance (fish1.transform.position, fishVector) > .1f)
		{
			fish1.transform.position = Vector3.MoveTowards (fish1.transform.position, fishVector, 250 * Time.deltaTime);
			yield return new WaitForSeconds (1);
		}
	}

	IEnumerator fish2Coroutine(Vector2 fishVector)
	{
		fish2.transform.Rotate(Time.deltaTime,0,5);
		while (Vector3.Distance (fish2.transform.position, fishVector) > 0.1f)
		{
			fish2.transform.position = Vector3.MoveTowards (fish2.transform.position, fishVector, 250 * Time.deltaTime);
			yield return new WaitForEndOfFrame ();
		}
	}

	IEnumerator fish3Coroutine(Vector2 fishVector)
	{
		fish3.transform.Rotate(Time.deltaTime,0,5);
		while (Vector3.Distance (fish3.transform.position, fishVector) > 0.1f)
		{
			fish3.transform.position = Vector3.MoveTowards (fish3.transform.position, fishVector, 250 * Time.deltaTime);
			yield return new WaitForEndOfFrame ();
		}
	}

	IEnumerator fish4Coroutine(Vector2 fishVector)
	{
		fish4.transform.Rotate(Time.deltaTime,0,5);
		while (Vector3.Distance (fish4.transform.position, fishVector) > 0.1f)
		{
			fish4.transform.position = Vector3.MoveTowards (fish4.transform.position, fishVector, 250 * Time.deltaTime);
			yield return new WaitForEndOfFrame ();
		}
	}

}


//if (questionInt == 9, lvl3 gad 7s
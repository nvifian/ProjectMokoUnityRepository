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
	public GameObject fish1;
	public GameObject fish2;
	public GameObject fish3;
	public GameObject fish4;
	public GameObject dolphinObject;
	public Text questionSetText;
	public Text questionText;
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
		lvlInt = 1;
		if (lvlInt == 1)
		{
			lvlText.text = "Level 1";
		}
		fish1Bool = false;
		fish2Bool = false;
		fish3Bool = false;
		fish4Bool = false;
	}

	public void Fish1 ()
	{
		fish1Bool = true;
		Invoke ("DolphinRoutine", 2);
		dolphinAnimation.Play ();
	}

	public void Fish2 ()
	{
		fish2Bool = true;
		dolphinAnimation.Play ();
		Invoke ("DolphinRoutine", 2);
	}

	public void Fish3 ()
	{
		fish3Bool = true;
		dolphinAnimation.Play ();
		Invoke ("DolphinRoutine", 2);
	}

	public void Fish4 ()
	{
		fish4Bool = true;
		dolphinAnimation.Play ();
		Invoke ("DolphinRoutine", 2);
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

	public void NewLevelRoutine()
	{
		if (newLevelBool == true)
		{
			xp9Object.SetActive (true);
			lvlText.text = "NEW LEVEL!";
			newLvlAnimation.Play ();
			levelUpAudio.Play ();
		}
	}

	void Update()
	{
		Debug.Log (questionInt);
		if (fish1Bool == true)
		{
			fish1.transform.Rotate (Time.deltaTime, 0, 5);
			fish1.transform.position = Vector2.MoveTowards (new Vector2 (0,350), boatVector, 1 * Time.deltaTime);
		}
		if (fish2Bool == true)
		{
			fish2.transform.Rotate (Time.deltaTime, 0, 5);
			fish2.transform.position = Vector2.MoveTowards (new Vector2 (0,350), boatVector, 1 * Time.deltaTime);
		}
		if (fish3Bool == true)
		{
			fish3.transform.Rotate (Time.deltaTime, 0, 5);
			fish3.transform.position = Vector2.MoveTowards (new Vector2 (0,350), boatVector, 1 * Time.deltaTime);
		}
		if (fish4Bool == true)
		{
			fish4.transform.Rotate (Time.deltaTime, 0, 5);
			fish4.transform.position = Vector2.MoveTowards (new Vector2 (0,350), boatVector, 1 * Time.deltaTime);
		}
		if (questionInt == 1)
		{
			lvlInt = 1;
			//xpText.text = questionInt + "  /  9";
			xp1Object.SetActive (true);
			questionText.text = "Little interest or pleasure in doing things";
		}
		if (questionInt == 2)
		{
			//xpText.text = questionInt + "  /  9";
			xp2Object.SetActive (true);
			questionText.text = "Feeling down, depressed or hopeless";
		}
		if (questionInt == 3)
		{
			//xpText.text = questionInt + "  /  9";
			xp3Object.SetActive (true);
			questionText.text = "Trouble falling asleep, or sleeping too much";
		}
		if (questionInt == 4)
		{
			//xpText.text = questionInt + "  /  9";
			xp4Object.SetActive (true);
			questionText.text = "Feeling tired or having little energy";
		}
		if (questionInt == 5)
		{
			//xpText.text = questionInt + "  /  9";
			xp5Object.SetActive (true);
			questionText.text = "Poor appetite or overeating";
		}
		if (questionInt == 6)
		{
			//xpText.text = questionInt + "  /  9";
			xp6Object.SetActive (true);
			questionText.text = "Feeling bad about yourself, or that you are a failure or let yourself or family down.";
		}
		if (questionInt == 7)
		{
			//xpText.text = questionInt + "  /  9";
			xp7Object.SetActive (true);
			questionText.text = "Trouble concentrating on things, such as reading the newspaper or watching television.";
		}
		if (questionInt == 8)
		{
			//xpText.text = questionInt + "  /  9";
			xp8Object.SetActive (true);
			questionText.text = "Moving or speaking so slowly that people hav noticed / being so fidgety that you have been moving a lot more than usual. ";
		}
		if (questionInt == 9)
		{
			newLevelBool = true;
			Invoke ("NewLevelRoutine",0f);
			newLevelBool = false;
			lvl2Bool = true;
			questionText.text = "Thoughts that you would be better off dead or of hurting yourself in some way";
		}
		//LVL 2 // CHANGE questionGroupText string
		if (questionInt == 10)
		{
			lvlInt = 2;
			//xpText.text =  " 0 /  11";
			xp1Object.SetActive (true);
			questionText.text = "Feeling nervous, anxious or on the edge.";
		}
		if (questionInt == 11)
		{
			//xpText.text = questionInt-9 + "  /  11";
			questionText.text = "Worrying too much about different things.";
		}
		if (questionInt == 12)
		{
			//xpText.text = questionInt-9 + "  /  11";
			questionText.text = "Trouble relaxing.";
		}
		if (questionInt == 13)
		{
			//xpText.text = questionInt-9 + "  /  11";
			questionText.text = "Being so restless that it is hard to sit still.";
		}
		if (questionInt == 14)
		{
			//xpText.text = questionInt-9 + "  /  11";
			questionText.text = "Beecoming easily annoyed or irritable.";
		}
		if (questionInt == 15)
		{
			//xpText.text = questionInt-9 + "  /  11";
			questionText.text = "Feeling afraid as if something awful might happen.";
		}
		if (questionInt == 16)
		{
			//xpText.text = questionInt-9 + "  /  11";
			questionText.text = "Little interest or pleasure in doing things";
		}
		if (questionInt == 17)
		{
			//xpText.text = questionInt-9 + "  /  11";
			questionText.text = "Thoughts that you would be better off dead or of hurting yourself in some way";
		}
		if (questionInt == 18)
		{
			//xpText.text = questionInt-9 + "  /  11";
			questionText.text = "Thoughts that you would be better off dead or of hurting yourself in some way";
		}
		if (questionInt ==19)
		{
			//xpText.text = questionInt-9 + "  /  11";
			questionText.text = "Thoughts that you would be better off dead or of hurting yourself in some way";
		}
		if (questionInt == 20)
		{
			//xpText.text = questionInt-9 + "  /  11";
			//xpText.text = "NEW ITEM!";
			questionText.text = "Thoughts that you would be better off dead or of hurting yourself in some way";
		}
		//LVL3
		if (questionInt == 21)
		{
			//xpText.text = questionInt-20 + "  /  14";
			questionSetText.text = 
			questionText.text = "Thoughts that you would be better off dead or of hurting yourself in some way";
		}
		if (questionInt == 22)
		{
			//xpText.text = questionInt-20 + "  /  14";
			questionText.text = "Thoughts that you would be better off dead or of hurting yourself in some way";
		}
		if (questionInt == 23)
		{
			questionText.text = "Thoughts that you would be better off dead or of hurting yourself in some way";
		}
		if (questionInt == 24)
		{
			questionText.text = "Thoughts that you would be better off dead or of hurting yourself in some way";
		}
		if (questionInt == 25)
		{
			questionText.text = "Thoughts that you would be better off dead or of hurting yourself in some way";
		}
		if (questionInt == 26)
		{
			questionText.text = "Thoughts that you would be better off dead or of hurting yourself in some way";
		}
		if (questionInt == 27)
		{
			questionText.text = "Thoughts that you would be better off dead or of hurting yourself in some way";
		}
		if (questionInt == 28)
		{
			questionText.text = "Thoughts that you would be better off dead or of hurting yourself in some way";
		}
		if (questionInt == 29)
		{
			questionText.text = "Thoughts that you would be better off dead or of hurting yourself in some way";
		}
		if (questionInt == 30)
		{
			questionText.text = "Thoughts that you would be better off dead or of hurting yourself in some way";
		}
	}
}


//if (questionInt == 9, lvl3 gad 7s
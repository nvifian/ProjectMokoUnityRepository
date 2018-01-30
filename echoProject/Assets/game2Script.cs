using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game2Script : MonoBehaviour
{

	// Use this for initialization
	void Start () {
		if (fishScript.questionInt == 34) {
			fishScript.questionInt = 35;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

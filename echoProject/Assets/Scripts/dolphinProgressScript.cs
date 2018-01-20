using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dolphinProgressScript : MonoBehaviour
{
	public static int questionInt;
	public Transform dolphinStickTransform;
	public Transform dot1a;
	public Transform dot1b;
	public Transform dot1c;
	public Transform dot2a;
	public Transform dot2b;
	public Transform dot2c;
	public Transform dot2d;
	public Transform dot3a;

	void Update ()
	{
		Debug.Log (questionInt);
		if (fishScript.questionInt == 0)
		{
			dolphinStickTransform.position = dot1a.position;
		}
		if (fishScript.questionInt == 1)
		{
			dolphinStickTransform.position = dot1a.position;
		}
		if (fishScript.questionInt == 2)
		{
			dolphinStickTransform.position = dot1a.position;
		}
		if (fishScript.questionInt == 3)
		{
			dolphinStickTransform.position = dot1b.position;
		}
		if (fishScript.questionInt == 4)
		{
			dolphinStickTransform.position = dot1b.position;
		}
		if (fishScript.questionInt == 5)
		{
			dolphinStickTransform.position = dot1b.position;
		}
		if (fishScript.questionInt == 6)
		{
			dolphinStickTransform.position = dot1c.position;
		}
		if (fishScript.questionInt == 7)
		{
			dolphinStickTransform.position = dot1c.position;
		}
		if (fishScript.questionInt == 8)
		{
			dolphinStickTransform.position = dot1c.position;
		}
		if (fishScript.questionInt == 9)
		{
			dolphinStickTransform.position = dot2a.position;
		}
		if (fishScript.questionInt == 10)
		{
			dolphinStickTransform.position = dot2a.position;
		}
		if (fishScript.questionInt == 11)
		{
			dolphinStickTransform.position = dot2a.position;
		}
		if (fishScript.questionInt == 12)
		{
			dolphinStickTransform.position = dot2b.position;
		}
		if (fishScript.questionInt == 13)
		{
			dolphinStickTransform.position = dot2b.position;
		}
		if (fishScript.questionInt == 14)
		{
			dolphinStickTransform.position = dot2b.position;
		}
		if (fishScript.questionInt == 15)
		{
			dolphinStickTransform.position = dot2c.position;
		}		
		if (fishScript.questionInt == 16)
		{
			dolphinStickTransform.position = dot2c.position;
		}
		if (fishScript.questionInt == 17)
		{
			dolphinStickTransform.position = dot2d.position;
		}
		if (fishScript.questionInt == 18)
		{
			dolphinStickTransform.position = dot2d.position;
		}
	}
}
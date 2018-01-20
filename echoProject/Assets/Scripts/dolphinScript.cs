using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dolphinScript : MonoBehaviour
{
	public Transform ballTransform;
	public Transform dolphinTransform;
	public Vector2 ballVector;
	public Animation dolphinAnimation;
	public AudioSource dolphinSplash;


	// Update is called once per frame
	void Update ()
	{
		if (avatarMenuScript.beachBallBool == true)
		{
			ballVector = ballTransform.position;
			dolphinTransform.transform.position = Vector2.MoveTowards (new Vector2 (transform.position.x, transform.position.y), ballVector, 50 * Time.deltaTime);

		}
	}

	public void AnimationRoutine()
	{
		dolphinAnimation.Play();
		dolphinSplash.Play ();
	}
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishTurnColliderScript : MonoBehaviour
{
	public GameObject fish1Object;
	public GameObject fish2Object;
	public GameObject fish3Object;
	public GameObject fish4Object;
	public ConstantForce2D fish1Force;
	public ConstantForce2D fish2Force;
	public ConstantForce2D fish3Force;
	public ConstantForce2D fish4Force;

	void OntriggerEnter (Collider other)
	{
		if (other.gameObject == fish1Object)
		{
			fish1Force.relativeForce =new Vector2 (-10, 0);
		}
			
	}

}
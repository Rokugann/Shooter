using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AircraftPitch : MonoBehaviour
{
	Vector3 velocity, tmp = new Vector3 ();

	private void Update ()
	{
		velocity = tmp - this.transform.position;
		tmp = this.transform.position;
		transform.rotation = Quaternion.Euler (new Vector3 (velocity.z * 3, 0f, -velocity.x * 24f));
	}
}

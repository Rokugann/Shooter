using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AircraftPitch : MonoBehaviour
{

//TODO
	[SerializeField]
	private float maxRot = 10f;

	private Rigidbody rb;

	private void Awake ()
	{
		rb = GetComponentInParent <Rigidbody> (); 
	}

	private void Update ()
	{
		transform.rotation = Quaternion.Euler(new Vector3 (rb.velocity.z * 1.5f, 0, -rb.velocity.x * 3f));
	}
}

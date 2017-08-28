using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AircraftPitch : MonoBehaviour
{

	public Rigidbody rb;
	public float maxRot = 10f;
	// Use this for initialization
	void Start ()
	{
		
	}

	// Update is called once per frame
	void Update ()
	{
		transform.rotation = Quaternion.Euler(new Vector3 (rb.velocity.z*1.5f, 0, -rb.velocity.x*3));
	}
}

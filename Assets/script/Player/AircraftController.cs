using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AircraftController : MonoBehaviour
{

//TODO Separate Shoot and Move

	public GameObject blaster;

	[SerializeField]
	private float moveSpeed = 10f;
	
	// Update is called once per frame
	private void Update ()
	{
		Vector3 v = this.transform.position, nv = new Vector3 ();

		nv.x = v.x + Input.GetAxis ("Vertical") * moveSpeed;
		nv.z = v.z + Input.GetAxis ("Horizontal") * moveSpeed;

		transform.position = nv;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AircraftController : MonoBehaviour
{
	[SerializeField]
	private float moveSpeed = 10f;

	[SerializeField]
	private GameObject pitchObject; //Used to rotate the vessel

	Plane ground;

	private void Awake ()
	{
		ground = new Plane (Vector3.up, 0f);
	}

	private void Update ()
	{
		Vector3 v = this.transform.position, nv = new Vector3 ();

		nv.x = v.x + Input.GetAxis ("Vertical") * moveSpeed;
		nv.z = v.z + Input.GetAxis ("Horizontal") * moveSpeed;

		transform.position = nv;
	}

	private void LateUpdate ()
	{
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		float dist;

		if (ground.Raycast (ray, out dist))
		{
			Vector3 l = ray.GetPoint (dist);
			Vector3 rot = l - transform.position;
			pitchObject.transform.rotation = Quaternion.LookRotation (rot);
		}
	}
}

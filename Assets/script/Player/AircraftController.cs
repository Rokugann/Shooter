using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AircraftController : MonoBehaviour
{

//TODO Separate Shoot and Move

	public GameObject blaster;

	[SerializeField]
	private float moveSpeed = 10f;

	[SerializeField]
  	float slowSpeed = 0.4f;


	private Transform[] shootPos;
	private Rigidbody rb;

	// Use this for initialization
	private void Start ()
	{
		rb = GetComponent <Rigidbody> ();
		shootPos = new Transform[blaster.transform.childCount];
		for (int i = 0; i < blaster.transform.childCount; i++)
			shootPos [i] = blaster.transform.GetChild (i);
	}
	
	// Update is called once per frame
	private void Update ()
	{
		Vector3 v = this.transform.position, nv = new Vector3 ();

		nv.x = v.x + Input.GetAxis ("Vertical") * moveSpeed;
		nv.z = v.z + Input.GetAxis ("Horizontal") * moveSpeed + slowSpeed;

		transform.position = nv;
	}
}

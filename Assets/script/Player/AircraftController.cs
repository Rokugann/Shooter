using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AircraftController : MonoBehaviour
{

	public GameObject blaster;
	public float moveSpeed = 10f;
	public float turnSpeed = 50f;
	public float maxSpeed = 5f;
	public float slowSpeed = 0.4f;
	Transform[] shootPos;
	Rigidbody rb;

	// Use this for initialization
	void Start ()
	{
		rb = GetComponent <Rigidbody> ();
		shootPos = new Transform[blaster.transform.childCount];
		for (int i = 0; i < blaster.transform.childCount; i++) {
			shootPos [i] = blaster.transform.GetChild (i);
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
	}

	void FixedUpdate ()
	{
		if (Input.GetKey (KeyCode.UpArrow) && rb.velocity.x > -maxSpeed)
			rb.AddForce (transform.right * -moveSpeed);
		else if (!Input.GetKey (KeyCode.UpArrow) && rb.velocity.x < 0f)
			rb.AddForce (transform.right * (moveSpeed * slowSpeed));
		
		if (Input.GetKey (KeyCode.DownArrow) && rb.velocity.x < maxSpeed)
			rb.AddForce (transform.right * moveSpeed);
		else if (!Input.GetKey (KeyCode.DownArrow) && rb.velocity.x > 0f)
			rb.AddForce (transform.right * -(moveSpeed * slowSpeed));
		
		if (Input.GetKey (KeyCode.LeftArrow) && rb.velocity.z > -maxSpeed)
			rb.AddForce (transform.forward * -moveSpeed);
		else if (!Input.GetKey (KeyCode.LeftArrow) && rb.velocity.z < 0f)
			rb.AddForce (transform.forward * (moveSpeed * slowSpeed));
		
		if (Input.GetKey (KeyCode.RightArrow) && rb.velocity.z < maxSpeed)
			rb.AddForce (transform.forward * moveSpeed);
		else if (!Input.GetKey (KeyCode.RightArrow) && rb.velocity.z > 0f)
			rb.AddForce (transform.forward * -(moveSpeed * slowSpeed));

		if (Input.GetKey (KeyCode.Space))
			blaster.SetActive(true);
		else
			blaster.SetActive (false);
	}
}

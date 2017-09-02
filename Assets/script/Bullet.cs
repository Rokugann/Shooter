using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	[SerializeField]
	private int damage = 50;

	[SerializeField]
	private float speed = 5f;

	private void Update ()
	{
		Vector3 v = transform.position;
		transform.position = new Vector3 (v.x, v.y, v.z + speed * Time.deltaTime);
	}

}

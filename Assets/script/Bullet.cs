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
		transform.Translate (Vector3.forward * speed * Time.deltaTime);
	}

}

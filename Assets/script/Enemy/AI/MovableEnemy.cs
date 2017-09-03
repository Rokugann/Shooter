using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableEnemy : MonoBehaviour
{
	[SerializeField]
	private float moveSpeed = 2f;

	public float speed
	{
		get {return moveSpeed; }
	}
}

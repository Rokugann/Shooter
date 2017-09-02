using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	[SerializeField]
	private Vector3 topLeftCollider = new Vector3 (), botRightCollider = new Vector3 ();

	private static Vector3 tlCollider, brCollider;

	private void Update ()
	{
		tlCollider = topLeftCollider + transform.position;
		brCollider = botRightCollider + transform.position;
	}

	public static Vector3 TopLeftCollider
	{
		get { return tlCollider; } 
	}

	public static Vector3 BotRightCollider
	{
		get { return brCollider; }
	}

	private void OnDrawGizmos ()
	{
		Gizmos.color = Color.red;
		Vector3 v = new Vector3 (topLeftCollider.x, 0f, botRightCollider.z);

		Gizmos.DrawLine (topLeftCollider, v);
		Gizmos.DrawLine (v, botRightCollider);

		v = new Vector3 (botRightCollider.x, 0f, topLeftCollider.z);
		Gizmos.DrawLine (botRightCollider, v);
		Gizmos.DrawLine (v, topLeftCollider);
	}
}

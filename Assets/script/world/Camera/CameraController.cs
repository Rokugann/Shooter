using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	[SerializeField]
	private Vector3 topLeftCollider = new Vector3 (), botRightCollider = new Vector3 ();

	private static Vector3 trueTLCollider, trueBRCollider, tlCollider, brCollider;

	private void Start ()
	{
		tlCollider = topLeftCollider + transform.position;
		brCollider = botRightCollider + transform.position;
	}

	private void Update ()
	{
		trueTLCollider = tlCollider + transform.position;
		trueBRCollider = brCollider + transform.position;
	}

	public static Vector3 TopLeftCollider
	{
		get { return trueTLCollider; }
		set { tlCollider = value; } 
	}

	public static Vector3 BotRightCollider
	{
		get { return trueBRCollider; }
		set { brCollider = value; }
	}

	private void OnDrawGizmos ()
	{
		CameraBoundDebug c = new CameraBoundDebug (topLeftCollider, botRightCollider, Color.red);
		c.DrawDebug ();
	}
}

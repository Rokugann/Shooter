using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	[SerializeField]
	private Vector3 topLeftCollider = new Vector3 (), botRightCollider = new Vector3 ();

	[SerializeField]
	private float zoomLevel = 30f, shift = 0.2f;

	private static Vector3 trueTLCollider, trueBRCollider, tlCollider, brCollider;
	private static float _zoomLevel, _shift = 0.2f;

	private void Start ()
	{
		tlCollider = topLeftCollider + transform.position;
		brCollider = botRightCollider + transform.position;
		_zoomLevel = zoomLevel;
	}

	private void LateUpdate ()
	{
		//======BOUNDARY=======
		trueTLCollider = tlCollider + transform.position;
		trueBRCollider = brCollider + transform.position;

		//======= ZOOM =======
		Vector3 v = transform.position;

		v.y = _zoomLevel;
		v.x = _shift * _zoomLevel;

		transform.position = v;
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

	public static float ZoomLevel
	{
		get { return _zoomLevel; }
		set { _zoomLevel = value; }
	}

	private void OnDrawGizmos ()
	{
		CameraBoundDebug c = new CameraBoundDebug (topLeftCollider, botRightCollider, Color.red);
		c.DrawDebug ();
	}
}

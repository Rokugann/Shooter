using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundModifier : ColliderBasedEvent
{
	[SerializeField]
	private Vector3 topLeftBound, botRightBound;

	protected override void OnExecute (GameObject player)
	{
		CameraController.BotRightCollider = botRightBound;
		CameraController.TopLeftCollider = topLeftBound;
	}

	private void OnDrawGizmos ()
	{
		CameraBoundDebug c = new CameraBoundDebug (topLeftBound, botRightBound, transform.position, Color.blue);
		c.DrawDebug ();
	}
}

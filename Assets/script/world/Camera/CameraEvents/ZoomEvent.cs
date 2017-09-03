using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomEvent : ColliderBasedEvent
{
	[SerializeField]
	private float zoom = 0f, smooth = 0f;

	private bool canZoom = false;
	private float curZoom, velocity = 0f;

	protected override void OnExecute (GameObject player)
	{
		if (zoom >= 0f)
		{
			if (smooth <= 0f)
				CameraController.ZoomLevel = zoom;
			else
			{
				curZoom = CameraController.ZoomLevel;
				canZoom = true;
			}
		}
		Destroy (this, smooth + 1f);
	}

	private void LateUpdate ()
	{
		if (canZoom)
		{
			curZoom = Mathf.SmoothDamp (curZoom, zoom, ref velocity, smooth);
			CameraController.ZoomLevel = curZoom;
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBoundDebug
{
	private Vector3 topLeftBound, botRightBound, centerPosition;
	private Color color;

	/// <summary>
	/// Initializes a new instance of the <see cref="CameraBoundDebug"/> class.
	/// the center position is the camera
	/// </summary>
	/// <param name="tlb">Topleft bound.</param>
	/// <param name="brb">botright bound.</param>
	/// <param name="c">Color of gizmos.</param>
	public CameraBoundDebug (Vector3 tlb, Vector3 brb, Color c)
	{
		topLeftBound = tlb;
		botRightBound = brb;
		centerPosition = new Vector3 ();
		color = c;
	}

	public CameraBoundDebug (Vector3 tlb, Vector3 brb, Vector3 centerPosition, Color c)
	{
		topLeftBound = tlb;
		botRightBound = brb;
		this.centerPosition = centerPosition;
		color = c;
	}

	public void DrawDebug ()
	{
		Vector3 cPos;

		if (centerPosition != new Vector3 ())
			cPos = centerPosition;
		else
		{
			cPos = Camera.main.transform.position;
		}
		cPos.y = 0f;
		Gizmos.color = color;
		Vector3 v = new Vector3 (topLeftBound.x, 0f, botRightBound.z) + cPos;

		Gizmos.DrawLine (topLeftBound + cPos, v);
		Gizmos.DrawLine (v , botRightBound + cPos);

		v = new Vector3 (botRightBound.x, 0f, topLeftBound.z) + cPos;
		Gizmos.DrawLine (botRightBound + cPos, v);
		Gizmos.DrawLine (v, topLeftBound + cPos);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollEvent : ColliderBasedEvent
{
	[SerializeField]
	private bool pause = false, reset = false;

	[SerializeField]
	private float speed = 0f;

	protected override void OnExecute (GameObject player)
	{
		if (pause)
			ScrollElement.PauseScrolling ();
		else if (speed >= 0f)
			ScrollElement.SetScrollSpeed = speed;
		else if (reset)
			ScrollElement.ResetScrolling ();
		
	}
}

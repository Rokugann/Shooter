using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Send some scroll event after a timer.
/// the timer is launched by triggering a collider or manually
/// </summary>
public class ScrollEventTimer : ColliderBasedEvent
{
	[SerializeField]
	private float timer, scrollSpeed = 0f;

	[SerializeField]
	private bool pause = false, reset = false;

	public void StartTimer ()
	{
		StartCoroutine (Timer ());
	}

	protected override void OnExecute (GameObject player)
	{
		StartTimer ();
	}

	private IEnumerator Timer ()
	{
		yield return new WaitForSeconds (timer);
		if (pause)
			ScrollElement.PauseScrolling ();
		else if (reset)
			ScrollElement.ResetScrolling ();
		else if (scrollSpeed >= 0f)
			ScrollElement.SetScrollSpeed = scrollSpeed;
	}
}

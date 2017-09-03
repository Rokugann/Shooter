using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// the base class for all camera events based on collision with a trigger collider.
/// this event trigger once
/// </summary>

[RequireComponent (typeof (Collider))]
public abstract class ColliderBasedEvent : MonoBehaviour
{
	private bool hasTriggered = false;

	private void OnTriggerEnter (Collider c)
	{
		if (c.tag == "Player" && !hasTriggered)
		{
			Debug.Log (this.gameObject.name + " has triggered");
			hasTriggered = true;
			OnExecute (c.gameObject);
		}
	}

	protected abstract void OnExecute (GameObject player);
}

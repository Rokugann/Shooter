using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExternEventTrigger : ColliderBasedEvent
{
	[SerializeField]
	private GameObject[] objectToTrigger;

	[SerializeField]
	private float timer = 0f;

	protected override void OnExecute (GameObject player)
	{
		if (timer >= 0f)
			StartCoroutine (ITimer ());

		for (int i = 0; i < objectToTrigger.Length; i ++)
		{
			foreach (IExternEvent e in objectToTrigger[i].GetComponentsInChildren <IExternEvent> ())
			{
				e.OnTriggerEvent (this.gameObject);
			}
		}
	}

	private IEnumerator ITimer ()
	{
		yield return new WaitForSeconds (timer);
	}
}

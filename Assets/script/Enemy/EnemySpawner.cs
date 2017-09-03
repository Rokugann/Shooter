using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour, IExternEvent
{
	[SerializeField]
	private float delay = 2f;

	[SerializeField]
	private bool grouping = true;

	[SerializeField]
	private Vector3 spawnerPositionShift;

	[SerializeField]
	private GameObject[] enemiesModels;
	[SerializeField]
	private int[] qty;


	private void Spawn ()
	{
		if (grouping)
		{
			for (int i = 0; i < enemiesModels.Length; i ++)
			{
				StartCoroutine (IPop (i, qty[i]));
			}
		}
		else
		{
			throw new System.NotImplementedException ();
		//TODO
//			int total = 0;
//			for (int i = 0; i < qty.Length; i ++)
//			{
//				total += qty[i];
//			}
//
//			int loop = qty.Length;
//			for (int i = 0; i < total; i ++)
//			{
//				if (i)
//			}
		}

	}

	public void OnTriggerEvent (GameObject sender)
	{
		Debug.Log ("Spawner ok");
		Spawn ();
	}

	private IEnumerator IPop (int enemy, int n)
	{
		for (int i = 0; i < n; i ++)
		{
			Instantiate
			(
				enemiesModels[enemy],
				transform.position + spawnerPositionShift,
				transform.rotation
			);
		}
		yield return new WaitForSeconds (delay);
	}

	private void OnDrawGizmos ()
	{
		Gizmos.color = Color.cyan;

		Gizmos.DrawSphere (transform.position + spawnerPositionShift, 0.7f);
	}
}

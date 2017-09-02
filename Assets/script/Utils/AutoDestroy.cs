using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
	[SerializeField]
	private float timeToDestroy = 2f;

	private IEnumerator IDestroy ()
	{
		yield return new WaitForSeconds (timeToDestroy);
		Destroy (this.gameObject);
	}
}

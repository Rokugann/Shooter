using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBoundRestricted : MonoBehaviour
{
	[SerializeField]
	private float boundSize;

	private void Update ()
	{
		Vector3
			v = transform.position,
			tlc = CameraController.TopLeftCollider,
			brc = CameraController.BotRightCollider
		;

		v.x = Mathf.Clamp (v.x, tlc.x + boundSize, brc.x - boundSize);
		v.z = Mathf.Clamp (v.z, tlc.z + boundSize, brc.z - boundSize);

		transform.position = v;
	}
}

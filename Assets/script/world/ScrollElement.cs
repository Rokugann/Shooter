using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollElement : MonoBehaviour
{
	private static float scrollSpeed = 5f, standardSpeed = 5f, tmp = 5f;

	private void Awake ()
	{
		standardSpeed = LevelManager.instance.scrollSpeed;
		scrollSpeed = standardSpeed;
		tmp = scrollSpeed;
	}

	private void Update ()
	{
		Vector3 v = this.transform.position;

		v.z += scrollSpeed * Time.deltaTime;
		this.transform.position = v;
	}

	/// <summary>
	/// Sets the scroll speed.
	/// </summary>
	/// <value>The scroll speed.</value>
	public static float SetScrollSpeed
	{
		set
		{
			scrollSpeed = value;
			tmp = scrollSpeed;
		}
	}

	/// <summary>
	/// Resets the scrolling to its standard speed.
	/// </summary>
	public static void ResetScrolling ()
	{
		scrollSpeed = standardSpeed;
		tmp = scrollSpeed;
	}

	/// <summary>
	/// Pauses the scrolling.
	/// </summary>
	public static void PauseScrolling ()
	{
		scrollSpeed = 0f;
	}

	/// <summary>
	/// Resumes the paused scrolling.
	/// </summary>
	public static void ResumeScrolling ()
	{
		scrollSpeed = tmp;
	}
}

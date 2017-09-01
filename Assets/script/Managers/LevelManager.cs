using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
	private static LevelManager _instance;

	[SerializeField]
	private float standardScrollSpeed = 0f;

	private void Awake ()
	{
		if (_instance != this && _instance != null)
			DestroyImmediate (this);
		_instance = this;
	}

	public float scrollSpeed
	{
		get { return standardScrollSpeed; }
	}

	public static LevelManager instance
	{
		get { return _instance; }
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
	private static LevelManager _instance;

	[SerializeField]
	private bool inverseScroll = true;

	[SerializeField]
	private float standardScrollSpeed = 0f;

	[SerializeField]
	private GameObject player;

	private void Awake ()
	{
		if (_instance != this && _instance != null)
			DestroyImmediate (this);
		_instance = this;
	}

	public void InverseScroll ()
	{
		inverseScroll = inverseScroll ? false : true;
	}

	public bool scrollIsReversed
	{
		get {return inverseScroll; }
	}

	public GameObject Player
	{
		get {return player; }
	}

	public float scrollSpeed
	{
		get {return inverseScroll ? -standardScrollSpeed : standardScrollSpeed; }
	}

	public static LevelManager instance
	{
		get { return _instance; }
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

[RequireComponent (typeof (MovableEnemy))]
public class FollowPlayer : MonoBehaviour
{
	[SerializeField]
	private float desiredDistance = 5f;

	private NavMeshAgent agent;

	private void Awake ()
	{
		agent = GetComponent <NavMeshAgent> ();
		agent.speed = GetComponent <MovableEnemy>().speed; 
		agent.stoppingDistance = desiredDistance;
		agent.isStopped = false;
	}

	private void Update ()
	{
		agent.destination = LevelManager.instance.Player.transform.position;
	}
}
